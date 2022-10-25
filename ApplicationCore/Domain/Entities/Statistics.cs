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
        public float SymbolsPerMinute { get; set; }
        public float Accuracy { get; set; }
        public int NumberOfMistakes { get; set; }
        public string Time { get; set; }
        public string? SharedVia { get; set; }
        public int UserId { get; set; }
        public int TextId { get; set; }
        public User User { get; set; }
        public Text Text { get; set; }
    }
}
