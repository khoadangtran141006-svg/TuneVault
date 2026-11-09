using MediatR;
using TuneVault.Application.DTOs.Playlist;

namespace TuneVault.Application.UseCases.Playlist;

// Query để lấy chi tiết playlist theo ID
public sealed class GetPlaylistByIdQuery : IRequest<PlaylistDetailDto?>
{
    public Guid PlaylistId { get; init; }
}
