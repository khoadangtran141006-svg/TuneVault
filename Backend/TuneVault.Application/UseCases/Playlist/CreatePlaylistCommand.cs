using MediatR;
using TuneVault.Application.DTOs.Playlist;

namespace TuneVault.Application.UseCases.Playlist;

// Command để tạo playlist mới
public sealed class CreatePlaylistCommand : IRequest<PlaylistDto>
{
    public Guid OwnerId { get; init; }
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public string? CoverImageUrl { get; init; }
    public bool IsPublic { get; init; } = true;
}
