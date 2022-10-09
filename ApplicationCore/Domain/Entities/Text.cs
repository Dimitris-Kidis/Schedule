using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace ApplicationCore.Domain.Entities
{
    public class Text : BaseEntity
    {
        public string TextContent { get; set; }
        public string Author { get; set; }
        public int Level { get; set; }
        public string Language { get; set; }
        public ICollection<Statistics> Statistics { get; set; }
    }
}
