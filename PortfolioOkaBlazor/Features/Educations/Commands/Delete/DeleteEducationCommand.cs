using MediatR;
using PortfolioOkaBlazor.Features.Educations.Dtos;

namespace PortfolioOkaBlazor.Features.Educations.Commands.Delete
{
    public record DeleteEducationCommand(Guid Id) : IRequest;
}