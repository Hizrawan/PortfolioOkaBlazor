using MediatR;
using Microsoft.EntityFrameworkCore;
using PortfolioOkaBlazor.Features.Skills.Dtos;
using PortfolioOkaBlazor.Persistence;

namespace PortfolioOkaBlazor.Features.Skills.Commands.Create
{
    public class CreateSkillCommandHandler(AppDbContext context) : IRequestHandler<CreateSkillCommand, Guid>
    {
        public async Task<Guid> Handle(CreateSkillCommand command, CancellationToken cancellationToken)
        {
            var Skill = new Domain.SkillData(command.Title, command.Description);
            await context.Skills.AddAsync(Skill);
            await context.SaveChangesAsync();
            return Skill.Id;
        }
    }
}
