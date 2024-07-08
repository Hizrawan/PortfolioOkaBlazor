using MediatR;
using PortfolioOkaBlazor.Features.WorkExperiences.Dtos;

namespace PortfolioOkaBlazor.Features.WorkExperiences.Queries.List
{
    public record ListWorkExperiencesQuery : IRequest<List<WorkExperienceDto>>;
}
