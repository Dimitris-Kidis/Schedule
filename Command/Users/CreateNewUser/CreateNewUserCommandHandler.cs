using ApplicationCore.Domain.Entities;
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
            if (_userRepository.GetAll().Any(user => user.Email == command.Email)) return Task.FromResult(-1);
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
                    ThemeColors = "",
                    Language = "English",
                    SignUpAt = DateTime.Now
                },
                StatisticsAVG = new()
                {
                    AvgSymbolsPerMin = 0,
                    AvgAccuracy = 0,
                    AvgTime = "00:00"
                },
                Images = new List<Image>()
                {
                    new Image { ImageTitle = "https://thumbs.dreamstime.com/b/default-avatar-profile-trendy-style-social-media-user-icon-187599373.jpg" }
                }
            };

            _userRepository.Add(user);
            _userRepository.Save();

            var resultId = user.Id;
            return Task.FromResult(resultId);
        }
    }
}
