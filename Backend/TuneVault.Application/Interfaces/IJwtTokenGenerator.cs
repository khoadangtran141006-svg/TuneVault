using TuneVault.Domain.Entities;

namespace TuneVault.Application.Interfaces;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
