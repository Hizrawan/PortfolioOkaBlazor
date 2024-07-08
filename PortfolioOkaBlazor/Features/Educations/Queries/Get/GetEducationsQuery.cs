using MediatR;
using PortfolioOkaBlazor.Features.Educations.Dtos;

namespace PortfolioOkaBlazor.Features.Educations.Queries.Get
{
    public record GetEducationQuery(Guid Id) : IRequest<EducationDto>;
}