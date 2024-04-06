using EFCoreFluentValidation.Models.DTOs;
using FluentValidation;

namespace EFCoreFluentValidation.Models.Validators;

public class UpdateUniversityRequestDtoValidator : AbstractValidator<UpdateUniversityRequestDto>
{
    public UpdateUniversityRequestDtoValidator()
    {
          RuleFor(x=>x.Name).NotEmpty().WithMessage("Name is not empty");
          RuleFor(x=>x.City).NotEmpty().WithMessage("City is not empty");
    }
}
