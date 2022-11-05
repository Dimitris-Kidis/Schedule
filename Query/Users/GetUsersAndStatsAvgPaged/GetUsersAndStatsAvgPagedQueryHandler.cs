using ApplicationCore.Domain.Entities;
using ApplicationCore.Pagination.PagedReq;
using ApplicationCore.Services.Repository;
using ApplicationCore.Services.Repository.UserRepository;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Users.GetUsersAndStatsAvgPaged
{
    public class GetUsersAndStatsAvgPagedQueryHandler : IRequestHandler<GetUsersAndStatsAvgPagedQuery, PaginatedResult<GetUsersAndStatsAvgPagedDto>>
    {
        private readonly IUserRepository<User> _usersRepository;
        private readonly ITypoRepository<ApplicationCore.Domain.Entities.StatisticsAVG> _statsRepository;
        private readonly IMapper _mapper;
        public GetUsersAndStatsAvgPagedQueryHandler(IUserRepository<User> usersRepository, ITypoRepository<ApplicationCore.Domain.Entities.StatisticsAVG> statsRepository, IMapper mapper)
        {
            _usersRepository = usersRepository;
            _statsRepository = statsRepository;
            _mapper = mapper;
        }
        public async Task<PaginatedResult<GetUsersAndStatsAvgPagedDto>> Handle(GetUsersAndStatsAvgPagedQuery request, CancellationToken cancellationToken)
        {

            var allUsers = await _usersRepository.GetAll().ToListAsync(cancellationToken);
            var allStats = await _statsRepository.GetAll().ToListAsync(cancellationToken);

            PagedRequest req = new()
            {
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                ColumnNameForSorting = request.ColumnNameForSorting,
                SortDirection = request.SortDirection,
                RequestFilters = request.RequestFilters
            };
            var pagedUsers = await _usersRepository.GetPagedUsersAvg<User, GetUsersAndStatsAvgPagedDto>(req);

            



            return pagedUsers;
        }
    }
}
