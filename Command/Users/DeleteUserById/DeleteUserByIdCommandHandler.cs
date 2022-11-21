using ApplicationCore.Services.Repository.UserRepository;
using MediatR;
using TYPO.ApplicationCore.Domain.Entities;

namespace Command.Users.DeleteUserById
{
    public class DeleteUserByIdCommandHandler : IRequestHandler<DeleteUserByIdCommand, int>
    {
        private readonly IUserRepository<User> _userRepository;
        public DeleteUserByIdCommandHandler(IUserRepository<User> userRepository)
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
