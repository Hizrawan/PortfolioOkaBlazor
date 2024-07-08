using MediatR;
using PortfolioOkaBlazor.Features.Educations.Dtos;

namespace PortfolioOkaBlazor.Features.Educations.Commands.Update
{
    public record UpdateEducationCommand(string UnivesityName, string Major, string GPA) : IRequest<Guid>;
}