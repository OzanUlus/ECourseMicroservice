using ECourseMicroservice.Catolog.Api.Repositories;
using ECourseMicroservice.Shared;
using MassTransit;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ECourseMicroservice.Catolog.Api.Features.Categories.Create
{
    public class CreateCategoryCommandHandler(AppDbContext context) : IRequestHandler<CreateCategoryCommand, ServiceResult<CreateCategoryResponse>>
    {
        public async Task<ServiceResult<CreateCategoryResponse>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var existCategory = await context.Categories.AnyAsync(c => c.Name == request.Name, cancellationToken: cancellationToken);

            if (existCategory) 
            {
                ServiceResult<CreateCategoryResponse>.Error("Category Name already exist", $"The category name '{request.Name}' already exist", System.Net.HttpStatusCode.BadRequest);
            }
            var category = new Category
            {
                Name = request.Name,
                Id = NewId.NextSequentialGuid()
            };

            await context.AddAsync(category, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);

            return ServiceResult<CreateCategoryResponse>.SuccessAsCreated(new CreateCategoryResponse(category.Id), "<empty>");
        }
    }
}
