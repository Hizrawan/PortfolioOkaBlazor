using MediatR;
using Microsoft.EntityFrameworkCore;
using PortfolioOkaBlazor.Features.Skills.Dtos;
using PortfolioOkaBlazor.Persistence;

namespace PortfolioOkaBlazor.Features.Skills.Queries.Get
{
    public class GetSkillQueryHandler(AppDbContext context)
     : IRequestHandler<GetSkillQuery, SkillDto?>
    {
        public async Task<SkillDto?> Handle(GetSkillQuery request, CancellationToken cancellationToken)
        {
            var Skill = await context.Skills.FindAsync(request.Id);
            if (Skill == null)
            {
                return null;
            }
            return new SkillDto(Skill.Id, Skill.Title, Skill.Description);
        }
    }
}
