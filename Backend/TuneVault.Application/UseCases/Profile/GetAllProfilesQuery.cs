using MediatR;
using TuneVault.Application.DTOs.Profile;

namespace TuneVault.Application.UseCases.Profile;

public sealed class GetAllProfilesQuery : IRequest<IEnumerable<ProfileDto>>
{
}
