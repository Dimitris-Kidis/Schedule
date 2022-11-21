using ApplicationCore.Services.Repository;
using MediatR;

namespace Command.Statistics.CreateNewStatisticLine
{
    public class CreateNewStatisticLineCommandHandler : IRequestHandler<CreateNewStatisticLineCommand, int>
    {
        private readonly ITypoRepository<ApplicationCore.Domain.Entities.Statistics> _statisticsRepository;
        public CreateNewStatisticLineCommandHandler(ITypoRepository<ApplicationCore.Domain.Entities.Statistics> statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }
        public Task<int> Handle(CreateNewStatisticLineCommand command, CancellationToken cancellationToken)
        {
            ApplicationCore.Domain.Entities.Statistics stats = new ()
            {
                UserId = command.UserId,
                TextId = command.TextId,
                SymbolsPerMinute = command.SymbolsPerMinute,
                Accuracy = command.Accuracy,
                Time = command.Time,
                NumberOfMistakes = command.NumberOfMistakes,
                SharedVia = command.SharedVia
            };

            _statisticsRepository.Add(stats);
            _statisticsRepository.Save();

            var resultId = stats.Id;
            return Task.FromResult(resultId);
        }
    }
}
