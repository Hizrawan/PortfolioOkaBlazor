using MediatR;
using Microsoft.EntityFrameworkCore;
using PortfolioOkaBlazor.Features.WorkExperiences.Dtos;
using PortfolioOkaBlazor.Persistence;

namespace PortfolioOkaBlazor.Features.WorkExperiences.Commands.Delete
{
    public class DeleteWorkExperienceCommandHandler(AppDbContext context) : IRequestHandler<DeleteWorkExperienceCommand>
    {
        public async Task Handle(DeleteWorkExperienceCommand request, CancellationToken cancellationToken)
        {
            var Work = await context.WorkExperiences.FindAsync(request.Id);
            if (Work == null) return;
            context.WorkExperiences.Remove(Work);
            await context.SaveChangesAsync();
        }
    }
}
