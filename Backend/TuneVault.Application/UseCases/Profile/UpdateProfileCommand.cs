using MediatR;
using TuneVault.Application.DTOs.Profile;

namespace TuneVault.Application.UseCases.Profile;

public sealed class UpdateProfileCommand : IRequest<ProfileDto?>
{
    public Guid Id { get; init; }
    public string UserName { get; init; } = string.Empty;
    public string? DisplayName { get; init; }
    public string? Bio { get; init; }
    public string? AvatarUrl { get; init; }
}
