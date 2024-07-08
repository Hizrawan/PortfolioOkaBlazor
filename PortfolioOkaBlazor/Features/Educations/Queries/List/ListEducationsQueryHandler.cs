using MediatR;
using Microsoft.EntityFrameworkCore;
using PortfolioOkaBlazor.Features.Educations.Dtos;
using PortfolioOkaBlazor.Persistence;

namespace PortfolioOkaBlazor.Features.Educations.Queries.List
{
    public class ListEducationsQueryHandler(AppDbContext context) : IRequestHandler<ListEducationsQuery, List<EducationDto>>
    {
        public async Task<List<EducationDto>> Handle(ListEducationsQuery request, CancellationToken cancellationToken)
        {
            return await context.Educations
                .Select(p => new EducationDto(p.Id, p.UniversityName, p.Major, p.GPA))
                .ToListAsync();
        }
    }
}
