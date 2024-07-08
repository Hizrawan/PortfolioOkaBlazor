using MediatR;
using PortfolioOkaBlazor.Features.Educations.Dtos;

namespace PortfolioOkaBlazor.Features.Educations.Queries.List
{
    public record ListEducationsQuery : IRequest<List<EducationDto>>;
}
