using ApplicationCore.Domain.Entities;
using Query.Pagination.Extensions;
using Query.Pagination;
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

            //var users = _usersRepository.GetAllUsersAndReview();
            //var usersImages = _usersRepository.GetAll().Include(x => x.Images);
            var allStats = _statsRepository.GetAll().ToList();
            var users = _usersRepository.GetAll().ToList();

            PagedRequest req = new()
            {
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                ColumnNameForSorting = request.ColumnNameForSorting,
                SortDirection = request.SortDirection,
                RequestFilters = request.RequestFilters
            };

            var q1 = (from a in users
                      join b in allStats on a.Id equals b.Id
                      orderby b.AvgSymbolsPerMin descending
                      select new UsersAvgStats
                      {
                          FirstName = a.FirstName,
                          LastName = a.LastName,
                          AvgSymbolsPerMin = b.AvgSymbolsPerMin,
                          AvgAccuracy = b.AvgAccuracy,
                          AvgTime = b.AvgTime
                      }
                      ).AsQueryable();

            return await q1.CreatePaginatedResultAsync<UsersAvgStats, GetUsersAndStatsAvgPagedDto>(req, _mapper);

            
        }
    }
}
