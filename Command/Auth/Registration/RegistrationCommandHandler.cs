using ApplicationCore.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using TYPO.ApplicationCore.Domain.Entities;

namespace Command.Auth.Registration
{
    public class RegistrationCommandHandler : IRequestHandler<RegistrationCommand, int>
    {
        private readonly UserManager<User> _userManager;
        public RegistrationCommandHandler(UserManager<User> userManager) 
        {
            _userManager = userManager;
        }
        public async Task<int> Handle(RegistrationCommand command, CancellationToken cancellationToken)
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
                CreatedAt = DateTimeOffset.Now,
                CreatedBy = command.Email,
                UserName = command.Email,
                UserInfo = new()
                {
                    ThemeColors = "",
                    Language = "English",
                    SignUpAt = DateTime.Now,
                    CreatedBy = command.Email,
                    CreatedAt = DateTime.Now,
                },
                StatisticsAVG = new()
                {
                    AvgSymbolsPerMin = 0,
                    AvgAccuracy = 0,
                    AvgTime = "00:00",
                    CreatedBy = command.Email,
                    CreatedAt = DateTime.Now,
                },
                Images = new List<Image>()
                {
                    new Image { ImageTitle = "https://thumbs.dreamstime.com/b/default-avatar-profile-trendy-style-social-media-user-icon-187599373.jpg", CreatedBy = "D", CreatedAt = DateTimeOffset.Now}
                }
            };

            var result = await _userManager.CreateAsync(user, command.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);

                return await Task.FromResult(-1);
            }

            var resultId = user.Id;

            return await Task.FromResult(resultId);
        }
    }
}
