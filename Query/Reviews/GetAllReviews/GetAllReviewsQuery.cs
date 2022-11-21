using MediatR;

namespace Query.Reviews.GetAllReviews
{
    public class GetAllReviewsQuery : IRequest<IEnumerable<ReviewDto>>
    {
    }
}
