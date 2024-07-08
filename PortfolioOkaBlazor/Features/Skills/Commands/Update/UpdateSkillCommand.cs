using MediatR;
using PortfolioOkaBlazor.Features.Skills.Dtos;

namespace PortfolioOkaBlazor.Features.Skills.Commands.Update
{
    public record UpdateSkillCommand(string Title, string Description) : IRequest<Guid>;
}