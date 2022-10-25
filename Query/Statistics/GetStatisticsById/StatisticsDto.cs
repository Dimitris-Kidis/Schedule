using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Statistics.GetStatisticsById
{
    public class StatisticsDto
    {
        public float SymbolsPerMinute { get; set; }
        public float Accuracy { get; set; }
        public string Time { get; set; }
        public int NumberOfMistakes { get; set; }
        public string? SharedVia { get; set; }
        public int UserId { get; set; }
    }
}
