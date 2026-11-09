using MediatR;
using TuneVault.Application.DTOs.Playlist;

namespace TuneVault.Application.UseCases.Playlist;

// Command để thay đổi quyền riêng tư của playlist
public sealed class SetPlaylistVisibilityCommand : IRequest<PlaylistDto>
{
    public Guid PlaylistId { get; init; }
    public bool IsPublic { get; init; }
    public Guid UserId { get; init; }
}
