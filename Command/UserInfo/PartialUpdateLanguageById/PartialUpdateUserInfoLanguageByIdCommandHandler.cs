using ApplicationCore.Services.Repository;
using MediatR;

namespace Command.UserInfo.PartialUpdateLanguageById
{
    public class PartialUpdateUserInfoLanguageByIdCommandHandler : IRequestHandler<PartialUpdateUserInfoLanguageByIdCommand, int>
    {
        private readonly ITypoRepository<ApplicationCore.Domain.Entities.UserInfo> _userInfoRepository;
        public PartialUpdateUserInfoLanguageByIdCommandHandler(ITypoRepository<ApplicationCore.Domain.Entities.UserInfo> userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }
        public Task<int> Handle(PartialUpdateUserInfoLanguageByIdCommand request, CancellationToken cancellationToken)
        {
            var stats = _userInfoRepository.FindBy(x => x.Id == request.Id).FirstOrDefault();
            if (stats != null)
            {
                stats.Language = request.Language;
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
