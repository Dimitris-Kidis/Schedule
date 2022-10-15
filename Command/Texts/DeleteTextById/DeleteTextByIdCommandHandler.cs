using ApplicationCore.Domain.Entities;
using ApplicationCore.Services.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Texts.DeleteTextById
{
    public class DeleteTextByIdCommandHandler : IRequestHandler<DeleteTextByIdCommand, Unit>
    {
        private readonly ITypoRepository<Text> _textRepository;
        public DeleteTextByIdCommandHandler(ITypoRepository<Text> textRepository)
        {
            this._textRepository = textRepository;
        }
        public Task<Unit> Handle(DeleteTextByIdCommand request, CancellationToken cancellationToken)
        {
            var user = _textRepository.GetByIdAsync(request.Id);
            if (user != null)
            {
                _textRepository.Delete(user.Result);
                _textRepository.Save();
            }
            return Task.FromResult(new Unit());
        }
    }
}
