using FluentValidation;

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
