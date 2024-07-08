using MediatR;
using PortfolioOkaBlazor.Features.Skills.Dtos;

namespace PortfolioOkaBlazor.Features.Skills.Queries.List
{
    public record ListSkillsQuery : IRequest<List<SkillDto>>;
}
