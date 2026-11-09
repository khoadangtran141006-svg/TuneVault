using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using TuneVault.Domain.Entities;
using TuneVault.Domain.Interfaces;

namespace TuneVault.Infrastructure.Dapper;

public sealed class DapperGenreRepository : IGenreRepository
{
    private readonly string _connectionString;

    public DapperGenreRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<Genre>> GetAllAsync(IDbTransaction? transaction = null)
    {
        const string sql = @"
            SELECT GenreId, Name, Description, CreatedAt
            FROM [Genres]
            ORDER BY CreatedAt ASC";

        await using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();
        return await connection.QueryAsync<Genre>(sql, transaction: transaction);
    }
}
