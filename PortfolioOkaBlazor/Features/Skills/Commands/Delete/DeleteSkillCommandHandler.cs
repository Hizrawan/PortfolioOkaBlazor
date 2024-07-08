using MediatR;
using Microsoft.EntityFrameworkCore;
using PortfolioOkaBlazor.Features.Skills.Dtos;
using PortfolioOkaBlazor.Persistence;

namespace PortfolioOkaBlazor.Features.Skills.Commands.Delete
{
    public class DeleteSkillCommandHandler(AppDbContext context) : IRequestHandler<DeleteSkillCommand>
    {
        public async Task Handle(DeleteSkillCommand request, CancellationToken cancellationToken)
        {
            var Skill = await context.Skills.FindAsync(request.Id);
            if (Skill == null) return;
            context.Skills.Remove(Skill);
            await context.SaveChangesAsync();
        }
    }
}
