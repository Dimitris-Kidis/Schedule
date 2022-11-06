﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Users.UpdateUser
{
    public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserCommandValidator()
        {
            var genderConditions = new List<string>() { "M", "F" };

            //RuleFor(role => role.IsAdmin)
            //    .NotEmpty()

            RuleFor(email => email.Email)
                .NotEmpty()
                .EmailAddress()
                .MinimumLength(5)
                .MaximumLength(30);

            RuleFor(user => user.FirstName)
                .NotEmpty().MinimumLength(2)
                .MaximumLength(30);

            RuleFor(user => user.LastName)
                .NotEmpty().MinimumLength(2)
                .MaximumLength(30);

            RuleFor(user => user.Password)
                .NotEmpty()
                .MinimumLength(8)
                .MaximumLength(20)
                .Matches("[A-Z]").WithMessage("'Password' must contain one or more capital letters.")
                .Matches("[a-z]").WithMessage("'Password' must contain one or more lowercase letters.")
                .Matches(@"\d").WithMessage("'Password' must contain one or more digits.")
                .Matches(@"[][""!@$%^&*(){}:;<>,.?/+_=|'~\\-]").WithMessage("'Password' must contain one or more special characters.");

            RuleFor(user => user.Age)
                .NotEmpty()
                .InclusiveBetween(4, 101);

            RuleFor(user => user.Gender)
                .NotEmpty()
                .Must(conditions =>
                    genderConditions.Contains(conditions)).WithMessage("Please only use: " + String.Join(", ", genderConditions));
        }
    }
}
