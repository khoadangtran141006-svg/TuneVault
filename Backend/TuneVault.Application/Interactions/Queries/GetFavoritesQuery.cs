using MediatR;

namespace TuneVault.Application.Interactions.Queries;

public record GetFavoritesQuery(string UserId) : IRequest<List<Guid>>;