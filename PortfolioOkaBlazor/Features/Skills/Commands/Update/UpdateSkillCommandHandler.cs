using MediatR;
using Microsoft.EntityFrameworkCore;
using PortfolioOkaBlazor.Features.Skills.Dtos;
using PortfolioOkaBlazor.Persistence;

namespace PortfolioOkaBlazor.Features.Skills.Commands.Update
{
    public class UpdateSkillCommandHandler(AppDbContext context) : IRequestHandler<UpdateSkillCommand, Guid>
    {
        public async Task<Guid> Handle(UpdateSkillCommand command, CancellationToken cancellationToken)
        {
            var Skill = new Domain.SkillData(command.Title, command.Description);
            await context.Skills.AddAsync(Skill);
            await context.SaveChangesAsync();
            return Skill.Id;
        }
    }
}
