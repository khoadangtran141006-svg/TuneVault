using MediatR;
using TuneVault.Application.DTOs.Genre;

namespace TuneVault.Application.UseCases.Genre;

public sealed class GetGenresQuery : IRequest<IEnumerable<GenreDto>>
{
}
