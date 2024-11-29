﻿using ECourseMicroservice.Catolog.Api.Features.Categories.Create;

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