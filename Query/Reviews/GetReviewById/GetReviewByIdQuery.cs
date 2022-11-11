using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Reviews.GetReviewById
{
    public class GetReviewByIdQuery : IRequest<GetReviewByIdDto>
    {
        public int Id { get; set; }
    }
}
