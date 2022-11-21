using MediatR;

namespace Query.Reviews.GetReviewById
{
    public class GetReviewByIdQuery : IRequest<GetReviewByIdDto>
    {
        public int Id { get; set; }
    }
}
