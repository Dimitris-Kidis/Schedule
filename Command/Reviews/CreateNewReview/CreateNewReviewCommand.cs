using MediatR;

namespace Command.Reviews.CreateNewReview
{
    public class CreateNewReviewCommand : IRequest<int>
    {
        public string ReviewContent { get; set; }
        public string UserEmail { get; set; } // ВОПРОС про айди или email
        public int TextId { get; set; }
    }
}
