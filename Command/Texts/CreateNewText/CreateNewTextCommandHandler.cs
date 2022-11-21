using ApplicationCore.Domain.Entities;
using ApplicationCore.Services.Repository;
using MediatR;

namespace Command.Texts.CreateNewText
{
    public class CreateNewTextCommandHandler : IRequestHandler<CreateNewTextCommand, int>
    {
        private readonly ITypoRepository<Text> _textRepository;
        public CreateNewTextCommandHandler(ITypoRepository<Text> textRepository)
        {
            _textRepository = textRepository;
        }
        public Task<int> Handle(CreateNewTextCommand command, CancellationToken cancellationToken)
        {
            Text text = new Text
            {
                TextContent = command.TextContent,
                Author = command.Author,
                Language = command.Language,
                Level = command.Level
            };

            _textRepository.Add(text);
            _textRepository.Save();

            var resultId = text.Id;
            return Task.FromResult(resultId);
        }
    }
}
