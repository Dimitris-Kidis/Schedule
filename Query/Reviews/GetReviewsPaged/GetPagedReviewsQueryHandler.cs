using ApplicationCore.Domain.Entities;
using Query.Pagination;
using ApplicationCore.Services.Repository;
using Query.Pagination.Extensions;
using AutoMapper;
using MediatR;
using ApplicationCore.Services.Repository.UserRepository;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Reviews.GetReviewsPaged
{
    public class GetPagedReviewsQueryHandler : IRequestHandler<GetPagedReviewsQuery, PaginatedResult<GetPagedReviewsDto>>
    {
        private readonly ITypoRepository<Review> _reviewsRepository;
        private readonly ITypoRepository<Text> _textsRepository;
        private readonly IUserRepository<User> _usersRepository;
        private readonly IMapper _mapper;
        public GetPagedReviewsQueryHandler(ITypoRepository<Review> reviewsRepository,
            ITypoRepository<Text> textsRepository,
            IUserRepository<User> usersRepository,
            IMapper mapper)
        {
            _textsRepository = textsRepository;
            _usersRepository = usersRepository;
            _reviewsRepository = reviewsRepository;
            _mapper = mapper;
        }
        public async Task<PaginatedResult<GetPagedReviewsDto>> Handle(GetPagedReviewsQuery request, CancellationToken cancellationToken)
        {
            PagedRequest req = new()
            {
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                ColumnNameForSorting = request.ColumnNameForSorting,
                SortDirection = request.SortDirection,
                RequestFilters = request.RequestFilters
            };

            var users = _usersRepository.GetAll();
            var reviews = _reviewsRepository.GetAll();
            var texts = _textsRepository.GetAll();
            var q1 = (from user in users
                      join review in reviews on user.Id equals review.UserId
                      join text in texts on review.TextId equals text.Id
                      select new PagedReviewsDto
                      {
                          Id = review.Id,
                          ReviewContent = review.ReviewContent,
                          TextContent = text.TextContent,
                          UserEmail = user.Email
                      }

                      );

            return await q1.CreatePaginatedResultAsync<PagedReviewsDto, GetPagedReviewsDto>(req, _mapper);
        }
    }
}
