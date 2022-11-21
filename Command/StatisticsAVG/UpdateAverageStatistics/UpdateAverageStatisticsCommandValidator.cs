using FluentValidation;

namespace Command.StatisticsAVG.UpdateAverageStatistics
{
    public class UpdateAverageStatisticsCommandValidator : AbstractValidator<UpdateAverageStatisticsCommand>
    {
        public UpdateAverageStatisticsCommandValidator()
        {
            RuleFor(stats => stats.Id)
                .NotEmpty();

            RuleFor(stats => stats.AvgSymbolsPerMin)
                .NotEmpty();

            RuleFor(stats => stats.AvgAccuracy)
                .NotEmpty();

            RuleFor(stats => stats.AvgTime)
                .NotEmpty();

            RuleFor(stats => stats.TextsCount)
                .NotEmpty();
        }
    }
}
