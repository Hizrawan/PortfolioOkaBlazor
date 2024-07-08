using MediatR;
using PortfolioOkaBlazor.Features.Skills.Dtos;

namespace PortfolioOkaBlazor.Features.Skills.Commands.Create
{
    public record CreateSkillCommand(string Title, string Description) : IRequest<Guid>;
}