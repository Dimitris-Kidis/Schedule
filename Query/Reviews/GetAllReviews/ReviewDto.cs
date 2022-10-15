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
        public string UserEmail { get; set; }
        //public string TextContent { get; set; } // ВОПРОС как возвращать textcontent
        public int TextId { get; set; }
    }
}
