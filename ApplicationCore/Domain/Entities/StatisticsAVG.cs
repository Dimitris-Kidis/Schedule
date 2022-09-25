using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace ApplicationCore.Domain.Entities
{
    public class StatisticsAVG : BaseEntity
    {
        public float AvgSymbolsPerMin { get; set; }
        public float AvgAccuracy { get; set; }
        public float AvgTime { get; set; }
        public User User { get; set; }
    }
}
