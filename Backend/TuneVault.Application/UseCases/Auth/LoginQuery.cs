using MediatR;
using TuneVault.Application.DTOs.Auth;

namespace TuneVault.Application.UseCases.Auth;

public sealed class LoginQuery : IRequest<AuthResponse?>
{
    public string Email { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;
}
