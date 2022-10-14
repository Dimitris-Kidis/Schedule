using ApplicationCore.Services.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace Command.Users.CreateNewUser
{
    public class CreateNewUserCommandHandler : IRequestHandler<CreateNewUserCommand, int>
    {
        private readonly ITypoRepository<User> _userRepository;
        public CreateNewUserCommandHandler(ITypoRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<int> Handle(CreateNewUserCommand command, CancellationToken cancellationToken)
        {
            User user = new User
            {
                IsAdmin = command.IsAdmin,
                Email = command.Email,
                FirstName = command.FirstName,
                LastName = command.LastName,
                Password = command.Password,
                Age = command.Age,
                Gender = command.Gender,
                UserInfo = new()
                {
                    ThemeId = 0,
                    Language = "English",
                    SignUpAt = DateTime.Now
                }
            };

            _userRepository.Add(user);
            _userRepository.Save();

            var resultId = user.Id;
            return Task.FromResult(resultId);
        }
    }
}
