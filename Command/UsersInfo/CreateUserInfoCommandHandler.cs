using ApplicationCore.Services.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace Command.UsersInfo
{
    public class CreateUserInfoCommandHandler : IRequestHandler<CreateUserInfoCommand, int>
    {
        private readonly ITypoRepository<UserInfo> _userInfoRepository;
        public CreateUserInfoCommandHandler(ITypoRepository<UserInfo> userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }
        public Task<int> Handle(CreateUserInfoCommand command, CancellationToken cancellationToken)
        {
            UserInfo userInfo = new UserInfo
            {
                Id = command.Id,
                SignUpAt = DateTime.Now,
                ThemeId = command.ThemeId,
                Language = command.Language,
                CreatedBy = "D",
                CreatedAt = DateTime.Now
            };

            _userInfoRepository.Add(userInfo);
            _userInfoRepository.Save();

            var resultId = userInfo.Id;
            return Task.FromResult(resultId);
        }
    }
}
