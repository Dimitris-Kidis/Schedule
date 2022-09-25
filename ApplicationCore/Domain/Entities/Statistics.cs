using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace ApplicationCore.Domain.Entities
{
    public class Statistics : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int TextId { get; set; }
        public Text Text { get; set; }
        public int SymbolsPerMinute { get; set; }
        public int Accuracy { get; set; }
        public int NumberOfMistakes { get; set; }
        public string SharedVia { get; set; }
        public string TypedAt { get; set; }
    }
}
