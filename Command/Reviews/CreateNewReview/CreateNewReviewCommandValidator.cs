using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Reviews.CreateNewReview
{
    public class CreateNewReviewCommandValidator : AbstractValidator<CreateNewReviewCommand>
    {
        public CreateNewReviewCommandValidator()
        {
            RuleFor(review => review.ReviewContent).NotEmpty().MinimumLength(50).MaximumLength(300);
            RuleFor(review => review.UserEmail).NotEmpty().EmailAddress().MinimumLength(5).MaximumLength(30);
            RuleFor(review => review.TextId).NotEmpty().ExclusiveBetween(0, 10000);
        }
    }
}
