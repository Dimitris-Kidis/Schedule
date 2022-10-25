using MediatR;

namespace Command.Reviews.CreateNewReview
{
    public class CreateNewReviewCommand : IRequest<int>
    {
        public string ReviewContent { get; set; }
        public int UserId { get; set; }
        public int TextId { get; set; }
    }
}
