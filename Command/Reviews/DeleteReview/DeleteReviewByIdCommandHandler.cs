using ApplicationCore.Domain.Entities;
using ApplicationCore.Services.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Reviews.DeleteReview
{
    public class DeleteReviewByIdCommandHandler : IRequestHandler<DeleteReviewByIdCommand, int>
    {
        private readonly ITypoRepository<Review> _reviewsRepository;
        public DeleteReviewByIdCommandHandler(ITypoRepository<Review> reviewRepository)
        {
            this._reviewsRepository = reviewRepository;
        }
        public Task<int> Handle(DeleteReviewByIdCommand request, CancellationToken cancellationToken)
        {
            if (!_reviewsRepository.GetAll().Any(review => review.Id == request.Id)) return Task.FromResult(-1);
            var review = _reviewsRepository.GetByIdAsync(request.Id);
            if (review != null)
            {
                _reviewsRepository.Delete(review.Result);
                _reviewsRepository.Save();
            }
            return Task.FromResult(0);
        }
    }
}
