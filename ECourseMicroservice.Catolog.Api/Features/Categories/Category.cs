using ECourseMicroservice.Catolog.Api.Features.Courses;
using ECourseMicroservice.Catolog.Api.Repositories;

namespace ECourseMicroservice.Catolog.Api.Features.Categories
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = default!;
        public List<Course>? Courses { get; set; }
    }
}
