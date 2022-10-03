using ApplicationCore.Services.Repository;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Users.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserDto>>
    {
        private readonly ITypoRepository<User> _textRepository;
        private readonly IMapper _mapper;
        public GetAllUsersQueryHandler(ITypoRepository<User> textRepository, IMapper mapper)
        {
            _textRepository = textRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _textRepository.GetAll().ToListAsync(cancellationToken);

            return users.Select(_mapper.Map<UserDto>);
        }
    }
}
