using ApplicationCore.Services.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace Command.Users.DeleteUserById
{
    public class DeleteUserByIdCommandHandler : IRequestHandler<DeleteUserByIdCommand, Unit>
    {
        private readonly ITypoRepository<User> _userRepository;
        public DeleteUserByIdCommandHandler(ITypoRepository<User> userRepository)
        {
            this._userRepository = userRepository;
        }
        public Task<Unit> Handle(DeleteUserByIdCommand request, CancellationToken cancellationToken)
        {
            var user = _userRepository.GetByIdAsync(request.Id);
            if (user != null)
            {
                _userRepository.Delete(user.Result);
                _userRepository.Save();
            }
            return Task.FromResult(new Unit());
        }
    }
}
