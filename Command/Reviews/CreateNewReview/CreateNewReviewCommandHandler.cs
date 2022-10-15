﻿using ApplicationCore.Domain.Entities;
using ApplicationCore.Services.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Reviews.CreateNewReview
{
    public class CreateNewReviewCommandHandler : IRequestHandler<CreateNewReviewCommand, int>
    {
        private readonly ITypoRepository<Review> _reviewRepository;
        public CreateNewReviewCommandHandler(ITypoRepository<Review> reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }
        public Task<int> Handle(CreateNewReviewCommand command, CancellationToken cancellationToken)
        {
            Review review = new Review
            {
                ReviewContent = command.ReviewContent,
                UserEmail = command.UserEmail,
                TextId = command.TextId
            };

            _reviewRepository.Add(review);
            _reviewRepository.Save();

            var resultId = review.Id;
            return Task.FromResult(resultId);
        }
    }
}