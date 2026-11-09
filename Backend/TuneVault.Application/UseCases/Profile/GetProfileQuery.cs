using MediatR;
using TuneVault.Application.DTOs.Profile;

namespace TuneVault.Application.UseCases.Profile;

public sealed class GetProfileQuery : IRequest<ProfileDto?>
{
    public Guid UserId { get; init; }
}
