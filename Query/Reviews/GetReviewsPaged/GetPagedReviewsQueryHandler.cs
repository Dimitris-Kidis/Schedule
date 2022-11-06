using ApplicationCore.Domain.Entities;
using ApplicationCore.Pagination.PagedReq;
using ApplicationCore.Services.Repository;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Reviews.GetReviewsPaged
{
    public class GetPagedReviewsQueryHandler : IRequestHandler<GetPagedReviewsQuery, PaginatedResult<PagedReviewsDto>>
    {
        private readonly ITypoRepository<Review> _reviewsRepository;
        private readonly IMapper _mapper;
        public GetPagedReviewsQueryHandler(ITypoRepository<Review> reviewsRepository, IMapper mapper)
        {
            _reviewsRepository = reviewsRepository;
            _mapper = mapper;
        }
        public async Task<PaginatedResult<PagedReviewsDto>> Handle(GetPagedReviewsQuery request, CancellationToken cancellationToken)
        {
            PagedRequest req = new()
            {
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                ColumnNameForSorting = request.ColumnNameForSorting,
                SortDirection = request.SortDirection,
                RequestFilters = request.RequestFilters
            };
            var pagedReviews = await _reviewsRepository.GetPaged<Review, PagedReviewsDto>(req);

            return pagedReviews;
        }
    }
}
