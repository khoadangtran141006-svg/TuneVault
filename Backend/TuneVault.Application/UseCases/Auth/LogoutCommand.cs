using MediatR;

namespace TuneVault.Application.UseCases.Auth;

public sealed class LogoutCommand : IRequest<bool>
{
    public Guid UserId { get; set; }
}
