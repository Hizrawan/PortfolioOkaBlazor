using MediatR;
using Microsoft.EntityFrameworkCore;
using PortfolioOkaBlazor.Features.WorkExperiences.Dtos;
using PortfolioOkaBlazor.Persistence;

namespace PortfolioOkaBlazor.Features.WorkExperiences.Queries.List
{
    public class ListWorkExperiencesQueryHandler(AppDbContext context) : IRequestHandler<ListWorkExperiencesQuery, List<WorkExperienceDto>>
    {
        public async Task<List<WorkExperienceDto>> Handle(ListWorkExperiencesQuery request, CancellationToken cancellationToken)
        {
            return await context.WorkExperiences
                .Select(p => new WorkExperienceDto(p.Id, p.CompanyName, p.Position, p.JobDesc))
                .ToListAsync();
        }
    }
}
