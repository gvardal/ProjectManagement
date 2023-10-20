using AuthServer.Core.Dtos;
using FluentValidation;

namespace AuthServerApi.Validations
{
    public class CreateUserDtoValidator : AbstractValidator<CreateUserDto>
    {
        public CreateUserDtoValidator()
        {
            RuleFor(x=> x.Email).NotEmpty().WithMessage("Email is required").WithMessage("Email is wrong");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is required");
        }
    }
}
