using FluentValidation;

namespace Command.Statistics.CreateNewStatisticLine
{
    public class CreateNewStatisticLineCommandValidator : AbstractValidator<CreateNewStatisticLineCommand>
    {
        public CreateNewStatisticLineCommandValidator()
        {
            var sharedViaConditions = new List<string>() { "Telegram", "VK", "Telegram&VK" };

            RuleFor(line => line.UserId)
                .NotEmpty();

            RuleFor(line => line.TextId)
                .NotEmpty();

            RuleFor(line => line.Time)
                .NotEmpty();

            RuleFor(line => line.SymbolsPerMinute)
                .NotEmpty();

            RuleFor(line => line.Accuracy)
                .NotEmpty();

            RuleFor(shared => shared.SharedVia)
                .Must(condition => sharedViaConditions.Contains(condition) == true || condition == null || condition == "");
        }
    }
}
