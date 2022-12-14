using ApplicationCore.Domain.Entities;
using Query.Pagination;
using ApplicationCore.Services.Repository;
using ApplicationCore.Services.Repository.UserRepository;
using AutoMapper;
using MediatR;
using Query.Pagination.Extensions;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Users.GetUsersPaged
{
    public class GetPagedUsersQueryHandler : IRequestHandler<GetPagedUsersQuery, PaginatedResult<PagedUsersDto>>
    {
        private readonly IUserRepository<User> _usersRepository;
        private readonly ITypoRepository<Image> _imagesRepository;
        private readonly IMapper _mapper;
        public GetPagedUsersQueryHandler(IUserRepository<User> usersRepository, ITypoRepository<Image> imagesRepository, IMapper mapper)
        {
            _usersRepository = usersRepository;
            _imagesRepository = imagesRepository;
            _mapper = mapper;
        }
        public async Task<PaginatedResult<PagedUsersDto>> Handle(GetPagedUsersQuery request, CancellationToken cancellationToken)
        {
            var users = _usersRepository.GetAll();
            var images = _imagesRepository.GetAll();
            PagedRequest req = new()
            {
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                ColumnNameForSorting = request.ColumnNameForSorting,
                SortDirection = request.SortDirection,
                RequestFilters = request.RequestFilters
            };
            var pagedUsers = await users.CreatePaginatedResultAsync<User, PagedUsersDto>(req, _mapper);

            for (int i = 0; i < pagedUsers.Items.Count; i++)
            {
                pagedUsers.Items[i].Avatar = images.Where(y => y.UserId == pagedUsers.Items[i].Id).OrderBy(x => x.Id).Select(x => x.ImageTitle).LastOrDefault();
            }

            return pagedUsers;
        }
    }
}

