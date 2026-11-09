using System.Data;
using TuneVault.Domain.Entities;

namespace TuneVault.Domain.Interfaces;

public interface IArtistRepository
{
    Task<Artist?> GetByNameAsync(string name, IDbTransaction? transaction = null);
    Task<Guid> AddAsync(Artist artist, IDbTransaction? transaction = null);
}
