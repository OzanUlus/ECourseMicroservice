using ECourseMicroservice.Shared;
using MediatR;

namespace ECourseMicroservice.Catolog.Api.Features.Categories.Create
{
    public record CreateCategoryCommand(string Name) : IRequest<ServiceResult<CreateCategoryResponse>>
    {
    }
}
