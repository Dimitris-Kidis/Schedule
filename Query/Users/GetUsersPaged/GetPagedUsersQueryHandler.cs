using ApplicationCore.Services.Repository;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Users.GetUsersPaged
{
    /*
    public class GetPagedUsersQueryHandler : IRequestHandler<GetPagedUsersQuery, IEnumerable<PagedUsersDto>>
    {
        private readonly ITypoRepository<User> _usersRepository;
        private readonly IMapper _mapper;
        public GetPagedUsersQueryHandler(ITypoRepository<User> userRepository, IMapper mapper)
        {
            _usersRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<PagedUsersDto>> Handle(GetPagedUsersQuery request, CancellationToken cancellationToken)
        {
            //var users = await _statisticsRepository.GetAll().ToListAsync(cancellationToken);
            var pagedUsers = await _usersRepository.GetPagedData<User, PagedUsersDto>(request);

            return users.Select(_mapper.Map<PagedUsersDto>);
        }
    }*/
}

