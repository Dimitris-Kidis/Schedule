using ApplicationCore.Services.Repository;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Users.GetInfoForDashboard
{
    public class GetInfoForDashboardQueryHandler : IRequestHandler<GetInfoForDashboardQuery, DashboardInfoDto>
    {
        private readonly ITypoRepository<User> _userRepository;
        private readonly IMapper _mapper;
        public GetInfoForDashboardQueryHandler(ITypoRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<DashboardInfoDto> Handle(GetInfoForDashboardQuery request, CancellationToken cancellationToken)
        {
            var user = _userRepository.GetWithInclude(x => x.Id == request.Id);

            return _mapper.Map<DashboardInfoDto>(user);
        }
    }
}
