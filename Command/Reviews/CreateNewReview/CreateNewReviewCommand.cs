using MediatR;

namespace Command.Reviews.CreateNewReview
{
    public class CreateNewReviewCommand : IRequest<int>
    {
        public string ReviewContent { get; set; }
        public string UserId { get; set; } // ВОПРОС про айди
        public int TextId { get; set; }
    }
}
