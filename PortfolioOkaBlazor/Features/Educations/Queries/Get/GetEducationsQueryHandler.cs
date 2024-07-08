using MediatR;
using Microsoft.EntityFrameworkCore;
using PortfolioOkaBlazor.Features.Educations.Dtos;
using PortfolioOkaBlazor.Persistence;

namespace PortfolioOkaBlazor.Features.Educations.Queries.Get
{
    public class GetEducationQueryHandler(AppDbContext context)
     : IRequestHandler<GetEducationQuery, EducationDto?>
    {
        public async Task<EducationDto?> Handle(GetEducationQuery request, CancellationToken cancellationToken)
        {
            var Education = await context.Educations.FindAsync(request.Id);
            if (Education == null)
            {
                return null;
            }
            return new EducationDto(Education.Id, Education.UniversityName, Education.Major, Education.GPA);
        }
    }
}
