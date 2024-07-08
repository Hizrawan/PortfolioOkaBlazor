using MediatR;
using PortfolioOkaBlazor.Features.Skills.Dtos;

namespace PortfolioOkaBlazor.Features.Skills.Commands.Delete
{
    public record DeleteSkillCommand(Guid Id) : IRequest;
}