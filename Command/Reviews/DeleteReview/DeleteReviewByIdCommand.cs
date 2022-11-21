using MediatR;

namespace Command.Reviews.DeleteReview
{
    public class DeleteReviewByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}

