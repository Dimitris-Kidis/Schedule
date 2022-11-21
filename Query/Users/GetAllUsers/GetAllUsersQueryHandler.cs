using ApplicationCore.Domain.Entities;
using ApplicationCore.Services.Repository;
using ApplicationCore.Services.Repository.UserRepository;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Users.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserDto>>
    {
        private readonly IUserRepository<User> _usersRepository;
        private readonly ITypoRepository<Image> _imageRepository;
        private readonly IMapper _mapper;
        public GetAllUsersQueryHandler(IUserRepository<User> userRepository, ITypoRepository<Image> imageRepository, IMapper mapper)
        {
            _usersRepository = userRepository;
            _imageRepository = imageRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        { 
            var users = await _usersRepository.GetAll().ToListAsync(cancellationToken);
            var images = await _imageRepository.GetAll().ToListAsync(cancellationToken);

          

            var q1 = (from image in images
                      join user in users on image.UserId equals user.Id into JoinedList
                      from user in JoinedList.DefaultIfEmpty()
                      select new UserDto
                      {
                          Id = user.Id,
                          FirstName = user.FirstName,
                          LastName = user.LastName,
                          Email = user.Email,
                          Avatar = images.Where(y => y.UserId == user.Id).Select(x => x.ImageTitle).LastOrDefault(),
                          Age = user.Age,
                          Gender = user.Gender,
                          IsAdmin = user.IsAdmin
                      });

            var q2 = (from user in users
                      join image in images on user.Id equals image.UserId into JoinedList
                      from image in JoinedList.DefaultIfEmpty()
                      select new UserDto
                      {
                          Id = user.Id,
                          FirstName = user.FirstName,
                          LastName = user.LastName,
                          Email = user.Email,
                          Avatar = images.Where(y => y.UserId == user.Id).Select(x => x.ImageTitle).LastOrDefault(),
                          Age = user.Age,
                          Gender = user.Gender,
                          IsAdmin = user.IsAdmin
                      });

            var query = q1.Union(q2).DistinctBy(x => x.Id).ToList();

            return query.Select(_mapper.Map<UserDto>);
        }
    }
}
