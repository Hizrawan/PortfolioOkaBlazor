using MediatR;
using Microsoft.EntityFrameworkCore;
using PortfolioOkaBlazor.Features.Educations.Dtos;
using PortfolioOkaBlazor.Persistence;

namespace PortfolioOkaBlazor.Features.Educations.Commands.Create
{
    public class CreateEducationCommandHandler(AppDbContext context) : IRequestHandler<CreateEducationCommand, Guid>
    {
        public async Task<Guid> Handle(CreateEducationCommand command, CancellationToken cancellationToken)
        {
            var Education = new Domain.EducationData(command.UnivesityName, command.Major, command.GPA);
            await context.Educations.AddAsync(Education);
            await context.SaveChangesAsync();
            return Education.Id;
        }
    }
}
