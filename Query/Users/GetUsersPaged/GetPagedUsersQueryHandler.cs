using ApplicationCore.Pagination.PagedReq;
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
    
    public class GetPagedUsersQueryHandler : IRequestHandler<GetPagedUsersQuery, PaginatedResult<PagedUsersDto>>
    {
        private readonly ITypoRepository<User> _usersRepository;
        private readonly IMapper _mapper;
        public GetPagedUsersQueryHandler(ITypoRepository<User> userRepository, IMapper mapper)
        {
            _usersRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<PaginatedResult<PagedUsersDto>> Handle(GetPagedUsersQuery request, CancellationToken cancellationToken)
        {
            PagedRequest req = new()
            {
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                ColumnNameForSorting = request.ColumnNameForSorting,
                SortDirection = request.SortDirection,
                RequestFilters = request.RequestFilters
            };
            var pagedUsers = await _usersRepository.GetPagedUsers<User, PagedUsersDto>(req);
            return pagedUsers;
        }
    }
}

