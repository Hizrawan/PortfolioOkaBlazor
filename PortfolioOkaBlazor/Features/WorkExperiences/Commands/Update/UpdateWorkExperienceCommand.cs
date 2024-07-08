using MediatR;
using PortfolioOkaBlazor.Features.WorkExperiences.Dtos;

namespace PortfolioOkaBlazor.Features.WorkExperiences.Commands.Update
{
    public record UpdateWorkExperienceCommand(string CompanyName, string Position, string JobDesc) : IRequest<Guid>;
}