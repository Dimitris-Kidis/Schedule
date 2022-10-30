using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace ApplicationCore.Domain.Entities
{
    public class Review : BaseEntity
    {
        public string ReviewContent { get; set; }
        public int UserId { get; set; }
        public int TextId { get; set; }
        public Text Text { get; set; }
    }
}
