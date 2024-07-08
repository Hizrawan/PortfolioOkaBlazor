using MediatR;
using PortfolioOkaBlazor.Features.WorkExperiences.Dtos;

namespace PortfolioOkaBlazor.Features.WorkExperiences.Commands.Create
{
    public record CreateWorkExperienceCommand(string CompanyName, string Position, string JobDesc) : IRequest<Guid>;
}