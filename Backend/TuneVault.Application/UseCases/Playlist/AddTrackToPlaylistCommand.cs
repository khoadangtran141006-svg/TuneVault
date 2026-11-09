using MediatR;
using TuneVault.Application.DTOs.Playlist;

namespace TuneVault.Application.UseCases.Playlist;

// Command để thêm track vào playlist
public sealed class AddTrackToPlaylistCommand : IRequest<PlaylistTrackDto>
{
    public Guid PlaylistId { get; init; }
    public Guid MediaId { get; init; }
    public Guid UserId { get; init; } 
    public int SortOrder { get; init; } = 0;
}
