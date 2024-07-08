using MediatR;
using Microsoft.EntityFrameworkCore;
using PortfolioOkaBlazor.Features.WorkExperiences.Dtos;
using PortfolioOkaBlazor.Persistence;

namespace PortfolioOkaBlazor.Features.WorkExperiences.Commands.Create
{
    public class CreateWorkExperienceCommandHandler(AppDbContext context) : IRequestHandler<CreateWorkExperienceCommand, Guid>
    {
        public async Task<Guid> Handle(CreateWorkExperienceCommand command, CancellationToken cancellationToken)
        {
            var Work = new Domain.WorkExperience(command.CompanyName, command.Position, command.JobDesc);
            await context.WorkExperiences.AddAsync(Work);
            await context.SaveChangesAsync();
            return Work.Id;
        }
    }
}
