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

          

            var q1 = (from a in images
                      join b in users on a.UserId equals b.Id into JoinedList
                      from b in JoinedList.DefaultIfEmpty()
                      select new UserDto
                      {
                          Id = b.Id,
                          FirstName = b.FirstName,
                          LastName = b.LastName,
                          Email = b.Email,
                          Avatar = images.Where(y => y.UserId == b.Id).Select(x => x.ImageTitle).LastOrDefault(),
                          Age = b.Age,
                          Gender = b.Gender,
                          IsAdmin = b.IsAdmin
                      });

            // right join: left table = TableB, right table = TableA
            var q2 = (from b in users
                      join a in images on b.Id equals a.UserId into JoinedList
                      from a in JoinedList.DefaultIfEmpty()
                      select new UserDto
                      {
                          Id = b.Id,
                          FirstName = b.FirstName,
                          LastName = b.LastName,
                          Email = b.Email,
                          Avatar = images.Where(y => y.UserId == b.Id).Select(x => x.ImageTitle).LastOrDefault(),
                          Age = b.Age,
                          Gender = b.Gender,
                          IsAdmin = b.IsAdmin
                      });

            var query = q1.Union(q2).DistinctBy(x => x.Id).ToList();

            return query.Select(_mapper.Map<UserDto>);
        }
    }
}
