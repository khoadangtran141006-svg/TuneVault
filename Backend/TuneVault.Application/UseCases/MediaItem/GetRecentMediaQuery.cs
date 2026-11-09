using MediatR;
using TuneVault.Application.DTOs.Media;

namespace TuneVault.Application.UseCases.Media;

public sealed class GetRecentMediaQuery : IRequest<IEnumerable<MediaDto>>
{
    public int Page { get; init; } = 1;
    public int PageSize { get; init; } = 20;
}
