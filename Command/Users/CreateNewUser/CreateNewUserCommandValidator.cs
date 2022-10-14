using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Users.CreateNewUser
{
    public class CreateNewUserCommandValidator : AbstractValidator<CreateNewUserCommand>
    {
        public CreateNewUserCommandValidator()
        {
            var genderConditions = new List<string>() { "M", "F" };
            RuleFor(role => role.IsAdmin).NotEmpty();
            RuleFor(email => email.Email).NotEmpty().EmailAddress().MinimumLength(5).MaximumLength(30);
            RuleFor(user => user.FirstName).NotEmpty().MinimumLength(2).MaximumLength(30);
            RuleFor(user => user.LastName).NotEmpty().MinimumLength(2).MaximumLength(30);
            RuleFor(user => user.Password).NotEmpty().MinimumLength(8).MaximumLength(20);
            RuleFor(user => user.Age).NotEmpty().InclusiveBetween(4, 101);
            RuleFor(user => user.Gender).NotEmpty().Must(conditions => genderConditions.Contains(conditions)).WithMessage("Please only use: " + String.Join(", ", genderConditions));
        }
    }
}