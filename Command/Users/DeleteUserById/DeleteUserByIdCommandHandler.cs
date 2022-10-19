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
    public class DeleteUserByIdCommandHandler : IRequestHandler<DeleteUserByIdCommand, int>
    {
        private readonly ITypoRepository<User> _userRepository;
        public DeleteUserByIdCommandHandler(ITypoRepository<User> userRepository)
        {
            this._userRepository = userRepository;
        }
        public Task<int> Handle(DeleteUserByIdCommand request, CancellationToken cancellationToken)
        {
            if (!_userRepository.GetAll().Any(user => user.Id == request.Id)) return Task.FromResult(-1);
            var user = _userRepository.GetByIdAsync(request.Id);
            if (user != null)
            {
                _userRepository.Delete(user.Result);
                _userRepository.Save();
            }
            return Task.FromResult(0);
        }
    }
}
