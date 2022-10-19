using ApplicationCore.Services.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.UserInfo.PartialUpdateThemeById
{
    public class PartialUpdateUserInfoThemeByIdCommandHandler : IRequestHandler<PartialUpdateUserInfoThemeByIdCommand, int>
    {
        private readonly ITypoRepository<ApplicationCore.Domain.Entities.UserInfo> _userInfoRepository;
        public PartialUpdateUserInfoThemeByIdCommandHandler(ITypoRepository<ApplicationCore.Domain.Entities.UserInfo> userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }
        public Task<int> Handle(PartialUpdateUserInfoThemeByIdCommand request, CancellationToken cancellationToken)
        {
            var stats = _userInfoRepository.FindBy(x => x.Id == request.Id).FirstOrDefault();
            if (stats != null)
            {
                stats.ThemeColors = request.ThemeColors;
                _userInfoRepository.Update(stats);
                _userInfoRepository.Save();
            } else
            {
                return Task.FromResult(-1);
            }


            return Task.FromResult(0);
        }
    }
}
