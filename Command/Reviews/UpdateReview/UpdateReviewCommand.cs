using MediatR;

namespace Command.Reviews.UpdateReview
{
    public class UpdateReviewCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string ReviewContent { get; set; }
        public int UserId { get; set; }
        public int TextId { get; set; }
    }
}
