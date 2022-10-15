using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Reviews.GetAllReviews
{
    public class GetAllReviewsQuery : IRequest<IEnumerable<ReviewDto>>
    {
    }
}
