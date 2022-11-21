using ApplicationCore.Domain.Entities;
using ApplicationCore.Services.Repository;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Query.Reviews.GetAllReviews
{
    public class GetAllReviewsQueryHandler : IRequestHandler<GetAllReviewsQuery, IEnumerable<ReviewDto>>
    {
        private readonly ITypoRepository<Review> _reviewRepository;
        private readonly ITypoRepository<Text> _textRepository;
        private readonly IMapper _mapper;
        public GetAllReviewsQueryHandler(ITypoRepository<Review> reviewRepository, IMapper mapper, ITypoRepository<Text> textRepository)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
            _textRepository = textRepository;
        }
        public async Task<IEnumerable<ReviewDto>> Handle(GetAllReviewsQuery request, CancellationToken cancellationToken)
        {
            var reviews = await _reviewRepository.GetAll().ToListAsync(cancellationToken);
            var texts = await _textRepository.GetAll().ToListAsync(cancellationToken);

            var data = from rev in reviews
                       join tex in texts
                       on rev.TextId equals tex.Id

                       select new ReviewDto
                       {
                           Id = rev.Id,
                           ReviewContent = rev.ReviewContent,
                           UserId = rev.UserId,
                           TextId = rev.TextId,
                           TextContent = tex.TextContent
                       };

            return data.Select(_mapper.Map<ReviewDto>);
        }
    }
}
