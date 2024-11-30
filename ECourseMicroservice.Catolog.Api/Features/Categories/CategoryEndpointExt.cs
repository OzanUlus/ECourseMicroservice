using ECourseMicroservice.Catolog.Api.Features.Categories.Create;
using ECourseMicroservice.Shared.Filters;

namespace ECourseMicroservice.Catolog.Api.Features.Categories
{
    public static class CategoryEndpointExt
    {
        public static void AddCategoryGroupEndpointExt(this WebApplication app) 
        {
            app.MapGroup("api/categories").CreateCategoryGroupItemEndpoint();
        }
    }
}
