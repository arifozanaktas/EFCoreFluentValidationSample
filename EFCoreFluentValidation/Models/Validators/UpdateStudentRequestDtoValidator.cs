using EFCoreFluentValidation.Models.DTOs;
using FluentValidation;

namespace EFCoreFluentValidation.Models.Validators;

public class UpdateStudentRequestDtoValidator : AbstractValidator<UpdateStudentRequestDto> 
{ 
    public UpdateStudentRequestDtoValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname is required");
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required").EmailAddress().WithMessage("Email is not valid");
    }
    
}
