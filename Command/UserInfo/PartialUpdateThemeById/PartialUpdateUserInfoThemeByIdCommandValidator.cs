using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.UserInfo.PartialUpdateThemeById
{
    public class PartialUpdateUserInfoThemeByIdCommandValidator : AbstractValidator<PartialUpdateUserInfoThemeByIdCommand>
    {
        public PartialUpdateUserInfoThemeByIdCommandValidator()
        {
            RuleFor(stats => stats.Id)
                .NotEmpty();

            RuleFor(stats => stats.ThemeColors)
                .NotEmpty()
                .MinimumLength(4);
        }
    }
}
