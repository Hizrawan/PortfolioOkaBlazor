using MediatR;
using Microsoft.EntityFrameworkCore;
using PortfolioOkaBlazor.Features.WorkExperiences.Dtos;
using PortfolioOkaBlazor.Persistence;

namespace PortfolioOkaBlazor.Features.WorkExperiences.Queries.Get
{
    public class GetWorkExperienceQueryHandler(AppDbContext context)
     : IRequestHandler<GetWorkExperiencesQuery, WorkExperienceDto?>
    {
        public async Task<WorkExperienceDto?> Handle(GetWorkExperiencesQuery request, CancellationToken cancellationToken)
        {
            var Work = await context.WorkExperiences.FindAsync(request.Id);
            if (Work == null)
            {
                return null;
            }
            return new WorkExperienceDto(Work.Id, Work.CompanyName, Work.Position, Work.JobDesc);
        }
    }
}
