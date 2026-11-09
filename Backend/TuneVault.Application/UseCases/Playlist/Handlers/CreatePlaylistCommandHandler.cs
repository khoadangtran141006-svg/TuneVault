using MediatR;
using TuneVault.Application.DTOs.Playlist;
using TuneVault.Domain.Entities;
using TuneVault.Domain.Interfaces;

namespace TuneVault.Application.UseCases.Playlist.Handlers;

public sealed class CreatePlaylistCommandHandler : IRequestHandler<CreatePlaylistCommand, PlaylistDto>
{
    private readonly IPlaylistRepository _playlistRepository;

    public CreatePlaylistCommandHandler(IPlaylistRepository playlistRepository)
    {
        _playlistRepository = playlistRepository;
    }

    public async Task<PlaylistDto> Handle(CreatePlaylistCommand request, CancellationToken cancellationToken)
    {
        var playlist = new TuneVault.Domain.Entities.Playlist
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Description = request.Description ?? string.Empty,
            CoverImageUrl = request.CoverImageUrl,
            IsPublic = request.IsPublic,
            OwnerId = request.OwnerId,
            CreatedAt = DateTime.UtcNow
        };

        var id = await _playlistRepository.CreateAsync(playlist);

        return new PlaylistDto
        {
            PlaylistId = id,
            Name = playlist.Name,
            Description = playlist.Description,
            CoverImageUrl = playlist.CoverImageUrl,
            IsPublic = playlist.IsPublic,
            OwnerId = playlist.OwnerId,
            CreatedAt = playlist.CreatedAt
        };
    }
}
