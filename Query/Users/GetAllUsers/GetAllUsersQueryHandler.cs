using ApplicationCore.Services.Repository;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Users.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserDto>>
    {
        private readonly ITypoRepository<User> _userRepository;
        private readonly IMapper _mapper;
        public GetAllUsersQueryHandler(ITypoRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAll().ToListAsync(cancellationToken);

            //return users.Select(_mapper.Map<IEnumerable<UserDto>>);
            return _mapper.Map<IEnumerable<UserDto>>(users);
        }
    }
}
