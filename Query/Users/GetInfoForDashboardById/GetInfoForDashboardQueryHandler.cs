using ApplicationCore.Domain.Entities;
using ApplicationCore.Services.Repository;
using ApplicationCore.Services.Repository.UserRepository;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Users.GetInfoForDashboard
{
    public class GetInfoForDashboardQueryHandler : IRequestHandler<GetInfoForDashboardQuery, DashboardInfoDto>
    {
        private readonly IUserRepository<User> _usersRepository;
        private readonly ITypoRepository<Image> _imageRepository;
        private readonly IMapper _mapper;
        public GetInfoForDashboardQueryHandler(IUserRepository<User> userRepository, ITypoRepository<Image> imageRepository, IMapper mapper)
        {
            _usersRepository = userRepository;
            _imageRepository = imageRepository;
            _mapper = mapper;
        }
        public async Task<DashboardInfoDto> Handle(GetInfoForDashboardQuery request, CancellationToken cancellationToken)
        {
            var user = _usersRepository.GetWithInclude(x => x.Id == request.Id);

            var images = await _imageRepository.GetAll().ToListAsync(cancellationToken);


            DashboardInfoDto dashboardDto = new()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Avatar = images.Where(y => y.UserId == user.Id).Select(x => x.ImageTitle).LastOrDefault(),
                Age = user.Age,
                Gender = user.Gender,
                IsAdmin = user.IsAdmin,
                Password = user.Password
            };

            return _mapper.Map<DashboardInfoDto>(dashboardDto);
        }
    }
}