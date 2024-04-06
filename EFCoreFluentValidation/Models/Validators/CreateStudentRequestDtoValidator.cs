using EFCoreFluentValidation.Models.DTOs;
using FluentValidation;

namespace EFCoreFluentValidation.Models.Validators;

public class CreateStudentRequestDtoValidator : AbstractValidator<CreateStudentRequestDto>
{
    public CreateStudentRequestDtoValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname is required");
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required").EmailAddress().WithMessage("Email is not valid");
        RuleFor(x => x.Phone).Length(10, 11).When(x => !string.IsNullOrEmpty(x.Email)).WithMessage("Phone number must be 10 or 11 caracters");

    }
}
