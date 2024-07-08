using MediatR;
using Microsoft.EntityFrameworkCore;
using PortfolioOkaBlazor.Features.Skills.Dtos;
using PortfolioOkaBlazor.Features.Skills.Queries.List;
using PortfolioOkaBlazor.Persistence;

namespace PortfolioOkaBlazor.Features.Skills.Queries.List
{
    public class ListSkillsQueryHandler(AppDbContext context) : IRequestHandler<ListSkillsQuery, List<SkillDto>>
    {
        public async Task<List<SkillDto>> Handle(ListSkillsQuery request, CancellationToken cancellationToken)
        {
            return await context.Skills
                .Select(p => new SkillDto(p.Id, p.Title, p.Description))
                .ToListAsync();
        }
    }
}
