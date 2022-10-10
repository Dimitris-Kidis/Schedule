using ApplicationCore.Domain.Entities;
using ApplicationCore.Services.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Text text = new Text // ВОПРОС: нужен ли dto
            {
                TextContent = command.TextContent,
                Author = command.Author,
                Language = command.Language,
                Level = command.Level,
                CreatedBy = "D",
                CreatedAt = DateTime.Now
            };

            _textRepository.Add(text);
            _textRepository.Save();

            var resultId = text.Id;
            return Task.FromResult(resultId);
        }
    }
}
