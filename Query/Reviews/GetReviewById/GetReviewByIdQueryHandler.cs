using ApplicationCore.Domain.Entities;
using ApplicationCore.Services.Repository;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Reviews.GetReviewById
{
    public class GetReviewByIdQueryHandler : IRequestHandler<GetReviewByIdQuery, GetReviewByIdDto>
    {
        private readonly ITypoRepository<Review> _reviewRepository;
        private readonly IMapper _mapper;
        public GetReviewByIdQueryHandler(ITypoRepository<Review> reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }
        public async Task<GetReviewByIdDto> Handle(GetReviewByIdQuery request, CancellationToken cancellationToken)
        {
            var review = _reviewRepository.FindBy(x => x.Id == request.Id).FirstOrDefault();

            GetReviewByIdDto dto = new()
            {
                Id = review.Id,
                ReviewContent = review.ReviewContent,
                TextId = review.TextId,
                UserId = review.UserId
            };

            return _mapper.Map<GetReviewByIdDto>(review);
        }
    }
}
