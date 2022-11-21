using Query.Pagination.Extensions;
using Query.Pagination;
using ApplicationCore.Services.Repository;
using ApplicationCore.Services.Repository.UserRepository;
using AutoMapper;
using MediatR;
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
            PagedRequest req = new()
            {
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                ColumnNameForSorting = request.ColumnNameForSorting,
                SortDirection = request.SortDirection,
                RequestFilters = request.RequestFilters
            };

            var stats = _statsRepository.GetAll();
            var users = _usersRepository.GetAll();


            var q1 = (from user in users
                      join stat in stats on user.Id equals stat.Id
                      orderby stat.AvgSymbolsPerMin descending
                      select new AverageDataDto
                      {
                          Id = user.Id,
                          FirstName = user.FirstName,
                          LastName = user.LastName,
                          AvgSymbolsPerMin = stat.AvgSymbolsPerMin,
                          AvgAccuracy = stat.AvgAccuracy,
                          AvgTime = stat.AvgTime
                      }
                      );
            return await q1.CreatePaginatedResultAsync<AverageDataDto, GetUsersAndStatsAvgPagedDto>(req, _mapper);
        }
    }
}
