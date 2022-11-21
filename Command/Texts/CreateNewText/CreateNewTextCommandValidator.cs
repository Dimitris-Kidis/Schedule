using FluentValidation;

namespace Command.Texts.CreateNewText
{
    public class CreateNewTextCommandValidator : AbstractValidator<CreateNewTextCommand>
    {
        public CreateNewTextCommandValidator()
        {
            var languageConditions = new List<string>() { "Russian", "English", "Romanian" };

            RuleFor(text => text.TextContent)
                .NotEmpty()
                .MinimumLength(50)
                .MaximumLength(500);

            RuleFor(author => author.Author)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(20);

            RuleFor(level => level.Level)
                .NotEmpty()
                .InclusiveBetween(1, 5);

            RuleFor(language => language.Language)
                .NotEmpty()
                .Must(conditions => languageConditions.Contains(conditions)).WithMessage("Please only use: " + String.Join(", ", languageConditions));
        }
    }
}
