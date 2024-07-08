using MediatR;
using PortfolioOkaBlazor.Features.Educations.Dtos;

namespace PortfolioOkaBlazor.Features.Educations.Commands.Create
{
    public record CreateEducationCommand(string UnivesityName, string Major, string GPA) : IRequest<Guid>;
}