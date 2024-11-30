using FluentValidation;

namespace ECourseMicroservice.Catolog.Api.Features.Categories.Create
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("{PropertyName} cannot be empty ")
                .Length(4,25).WithMessage("{PropertyName} must be 4 and 25 characters");
        }
    }
}
