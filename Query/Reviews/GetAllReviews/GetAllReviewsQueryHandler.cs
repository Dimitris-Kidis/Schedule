using ApplicationCore.Domain.Entities;
using ApplicationCore.Services.Repository;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Reviews.GetAllReviews
{
    public class GetAllReviewsQueryHandler : IRequestHandler<GetAllReviewsQuery, IEnumerable<ReviewDto>>
    {
        private readonly ITypoRepository<Review> _reviewRepository;
        private readonly IMapper _mapper;
        public GetAllReviewsQueryHandler(ITypoRepository<Review> reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ReviewDto>> Handle(GetAllReviewsQuery request, CancellationToken cancellationToken)
        {
            var users = await _reviewRepository.GetAll().ToListAsync(cancellationToken); // ВОПРОС про textcontent

            return users.Select(_mapper.Map<ReviewDto>);
        }
    }
}
