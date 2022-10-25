using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.StatisticsAVG.GetAverageDataById
{
    public class AverageDataDto
    {
        public float AvgSymbolsPerMin { get; set; }
        public float AvgAccuracy { get; set; }
        public string AvgTime { get; set; }
        public int TextsCount { get; set; }
    }
}
