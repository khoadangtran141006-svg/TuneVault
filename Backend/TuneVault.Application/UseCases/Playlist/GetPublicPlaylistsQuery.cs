using MediatR;
using TuneVault.Application.DTOs.Playlist;

namespace TuneVault.Application.UseCases.Playlist;

public sealed class GetPublicPlaylistsQuery : IRequest<IEnumerable<PlaylistSummaryDto>>
{
}
