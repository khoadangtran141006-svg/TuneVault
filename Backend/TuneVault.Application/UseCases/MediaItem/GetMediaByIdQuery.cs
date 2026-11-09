
using MediatR;
using TuneVault.Application.DTOs.Media;

namespace TuneVault.Application.UseCases.Media;

public sealed class GetMediaByIdQuery : IRequest<MediaDto?>
{
    public Guid MediaId { get; init; }
}