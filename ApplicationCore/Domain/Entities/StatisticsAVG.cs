using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string AvgTime { get; set; }
        public int TextsCount { get; set; }
        public User User { get; set; }
    }
}
