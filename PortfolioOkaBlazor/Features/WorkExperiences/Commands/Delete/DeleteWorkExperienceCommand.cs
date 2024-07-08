using MediatR;
using PortfolioOkaBlazor.Features.WorkExperiences.Dtos;

namespace PortfolioOkaBlazor.Features.WorkExperiences.Commands.Delete
{
    public record DeleteWorkExperienceCommand(Guid Id) : IRequest;
}