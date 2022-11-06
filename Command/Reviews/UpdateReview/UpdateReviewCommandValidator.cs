using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Reviews.UpdateReview
{
    public class UpdateReviewCommandValidator : AbstractValidator<UpdateReviewCommand>
    {
        public UpdateReviewCommandValidator()
        {
            RuleFor(review => review.ReviewContent)
                .NotEmpty()
                .MinimumLength(50)
                .MaximumLength(300);

            RuleFor(review => review.UserId)
                .NotEmpty();

            RuleFor(review => review.TextId)
                .NotEmpty()
                .ExclusiveBetween(0, 10000);
        }
    }
}
