using MediatR;
using PortfolioOkaBlazor.Features.Educations.Dtos;
using PortfolioOkaBlazor.Features.Skills.Dtos;

namespace PortfolioOkaBlazor.Features.Skills.Queries.Get
{
    public record GetSkillQuery(Guid Id) : IRequest<SkillDto>;
}