using ApplicationCore.Domain.Entities;
using ApplicationCore.Services.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Reviews.UpdateReview
{
    public class UpdateReviewCommandHandler : IRequestHandler<UpdateReviewCommand, int>
    {
        private readonly ITypoRepository<Review> _reviewsAVGRepository;
        public UpdateReviewCommandHandler(ITypoRepository<Review> reviewsAVGRepository)
        {
            _reviewsAVGRepository = reviewsAVGRepository;
        }
        public Task<int> Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
        {
            var review = _reviewsAVGRepository.FindBy(x => x.Id == request.Id).FirstOrDefault();
            if (review != null)
            {
                review.Id = request.Id;
                review.ReviewContent = request.ReviewContent;
                review.UserId = request.UserId;
                review.TextId = request.TextId;
                _reviewsAVGRepository.Update(review);
                _reviewsAVGRepository.Save();
            }
            else
            {
                return Task.FromResult(-1);
            }

            return Task.FromResult(0);
        }
    }
}
