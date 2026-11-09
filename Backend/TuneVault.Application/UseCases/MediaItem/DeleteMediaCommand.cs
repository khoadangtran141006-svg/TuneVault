
using MediatR;

namespace TuneVault.Application.UseCases.Media;

public sealed class DeleteMediaCommand : IRequest<bool>
{
    public Guid MediaId { get; init; }
    public Guid UserId { get; init; }
}