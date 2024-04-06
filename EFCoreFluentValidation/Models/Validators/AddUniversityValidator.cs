using EFCoreFluentValidation.Models.DTOs;
using FluentValidation;

namespace EFCoreFluentValidation.Models.Validators;

public class AddUniversityRequestDtoValidator : AbstractValidator<AddUniversityRequestDto>
{
    public AddUniversityRequestDtoValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.City).NotEmpty().WithMessage("City is required");
    }
}
