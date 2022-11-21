using ApplicationCore.Domain.Entities;
using ApplicationCore.Services.Repository;
using MediatR;

namespace Command.Texts.DeleteTextById
{
    public class DeleteTextByIdCommandHandler : IRequestHandler<DeleteTextByIdCommand, int>
    {
        private readonly ITypoRepository<Text> _textRepository;
        public DeleteTextByIdCommandHandler(ITypoRepository<Text> textRepository)
        {
            this._textRepository = textRepository;
        }
        public Task<int> Handle(DeleteTextByIdCommand request, CancellationToken cancellationToken)
        {
            var user = _textRepository.GetByIdAsync(request.Id);
            if (user != null)
            {
                _textRepository.Delete(user.Result);
                _textRepository.Save();
            } else
            {
                return Task.FromResult(-1);
            }
            return Task.FromResult(0);
        }
    }
}
