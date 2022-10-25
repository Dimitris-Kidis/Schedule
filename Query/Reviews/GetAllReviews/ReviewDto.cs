using ApplicationCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Reviews.GetAllReviews
{
    public class ReviewDto
    {
        public int Id { get; set; }
        public string ReviewContent { get; set; }
        public int UserId { get; set; }
        public int TextId { get; set; }
        public string TextContent { get; set; }
        
    }
}
