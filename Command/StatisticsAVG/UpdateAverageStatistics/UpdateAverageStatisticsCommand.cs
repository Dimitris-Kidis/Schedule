using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.StatisticsAVG.UpdateAverageStatistics
{
    public class UpdateAverageStatisticsCommand : IRequest<int>
    {
        public int Id { get; set; }
        public float AvgSymbolsPerMin { get; set; }
        public float AvgAccuracy { get; set; }
        public float AvgTime { get; set; }
        public int TextsCount { get; set; }
    }
}
