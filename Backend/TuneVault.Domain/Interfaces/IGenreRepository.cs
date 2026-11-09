using System.Data;
using TuneVault.Domain.Entities;

namespace TuneVault.Domain.Interfaces;

public interface IGenreRepository
{
    Task<IEnumerable<Genre>> GetAllAsync(IDbTransaction? transaction = null);
}
