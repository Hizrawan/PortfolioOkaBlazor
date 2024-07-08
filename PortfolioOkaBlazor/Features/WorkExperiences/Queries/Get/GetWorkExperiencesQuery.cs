using MediatR;
using PortfolioOkaBlazor.Features.WorkExperiences.Dtos;

namespace PortfolioOkaBlazor.Features.WorkExperiences.Queries.Get
{
    public record GetWorkExperiencesQuery(Guid Id) : IRequest<WorkExperienceDto>;
}