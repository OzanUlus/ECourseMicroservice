using AutoMapper;
using ECourseMicroservice.Catolog.Api.Features.Categories.Dtos;

namespace ECourseMicroservice.Catolog.Api.Features.Categories
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
