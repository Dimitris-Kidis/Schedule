using ApplicationCore.Domain.Entities;
using ApplicationCore.Services.Repository;
using MediatR;

namespace Command.Texts.UpdateText
{
    public class UpdateTextCommandHandler : IRequestHandler<UpdateTextCommand, int>
    {
        private readonly ITypoRepository<Text> _textsAVGRepository;
        public UpdateTextCommandHandler(ITypoRepository<Text> statsAVGRepository)
        {
            _textsAVGRepository = statsAVGRepository;
        }
        public Task<int> Handle(UpdateTextCommand request, CancellationToken cancellationToken)
        {
            var text = _textsAVGRepository.FindBy(x => x.Id == request.Id).FirstOrDefault();
            if (text != null)
            {
                text.Id = request.Id;
                text.TextContent = request.TextContent;
                text.Author = request.Author;
                text.Level = request.Level;
                text.Language = request.Language;
                _textsAVGRepository.Update(text);
                _textsAVGRepository.Save();
            }
            else
            {
                return Task.FromResult(-1);
            }

            return Task.FromResult(0);
        }
    }
}
