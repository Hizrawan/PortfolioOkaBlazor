using MediatR;
using Microsoft.EntityFrameworkCore;
using PortfolioOkaBlazor.Features.Educations.Dtos;
using PortfolioOkaBlazor.Persistence;

namespace PortfolioOkaBlazor.Features.Educations.Commands.Delete
{
    public class DeleteEducationCommandHandler(AppDbContext context) : IRequestHandler<DeleteEducationCommand>
    {
        public async Task Handle(DeleteEducationCommand request, CancellationToken cancellationToken)
        {
            var Education = await context.Educations.FindAsync(request.Id);
            if (Education == null) return;
            context.Educations.Remove(Education);
            await context.SaveChangesAsync();
        }
    }
}
