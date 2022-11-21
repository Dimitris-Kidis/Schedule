using ApplicationCore.Services.Repository.UserRepository;
using MediatR;
using TYPO.ApplicationCore.Domain.Entities;

namespace Command.Users.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, int>
    {
        private readonly IUserRepository<User> _userRepository;
        public UpdateUserCommandHandler(IUserRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<int> Handle(UpdateUserCommand command, CancellationToken cancellationToken)
        {
            var user = _userRepository.FindBy(x => x.Id == command.Id).FirstOrDefault();
            if (user != null)
            {
                user.IsAdmin = command.IsAdmin;
                user.Email = command.Email;
                user.FirstName = command.FirstName;
                user.LastName = command.LastName;
                user.Password = command.Password;
                user.Age = command.Age;
                user.Gender = command.Gender;
                _userRepository.Update(user);
                _userRepository.Save();
            }
            else
            {
                return Task.FromResult(-1);
            }

            return Task.FromResult(0);
        }
    }
}
