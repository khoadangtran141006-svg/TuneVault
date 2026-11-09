using MediatR;
using TuneVault.Application.DTOs.Playlist;

namespace TuneVault.Application.UseCases.Playlist;

public sealed class GetUserPlaylistsQuery : IRequest<IEnumerable<PlaylistSummaryDto>>
{
    public Guid UserId { get; init; }
}