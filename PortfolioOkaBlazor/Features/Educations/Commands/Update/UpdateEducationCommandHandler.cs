using MediatR;
using Microsoft.EntityFrameworkCore;
using PortfolioOkaBlazor.Features.Educations.Dtos;
using PortfolioOkaBlazor.Persistence;

namespace PortfolioOkaBlazor.Features.Educations.Commands.Update
{
    public class UpdateEducationCommandHandler(AppDbContext context) : IRequestHandler<UpdateEducationCommand, Guid>
    {
        public async Task<Guid> Handle(UpdateEducationCommand command, CancellationToken cancellationToken)
        {
            var Education = new Domain.EducationData(command.UnivesityName, command.Major, command.GPA);
            await context.Educations.AddAsync(Education);
            await context.SaveChangesAsync();
            return Education.Id;
        }
    }
}
