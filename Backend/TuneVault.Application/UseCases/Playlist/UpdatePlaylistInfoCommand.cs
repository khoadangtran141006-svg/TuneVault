using MediatR;
using TuneVault.Application.DTOs.Playlist;

namespace TuneVault.Application.UseCases.Playlist;

public sealed class UpdatePlaylistInfoCommand : IRequest<PlaylistDto>
{
    public Guid PlaylistId { get; init; }
    public Guid UserId { get; init; }
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public string? CoverImageUrl { get; init; }
}
