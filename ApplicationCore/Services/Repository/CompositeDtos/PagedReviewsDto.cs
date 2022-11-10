using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services.Repository.CompositeDtos
{
    public class PagedReviewsDto
    {
        public int Id { get; set; }
        public string ReviewContent { get; set; }
        public string UserEmail { get; set; }
        public string TextContent { get; set; }
    }
}
