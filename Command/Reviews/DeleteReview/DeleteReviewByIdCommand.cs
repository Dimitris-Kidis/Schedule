using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Reviews.DeleteReview
{
    public class DeleteReviewByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}

