using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.ViewModels
{
    public class ChartDataViewModel
    {
        public float AvgSymbolsPerMin { get; set; }
        public float AvgAccuracy { get; set; }
        public float AvgTime { get; set; }
        public int FastestSpeed { get; set; }
        public DateTime SignUpAt { get; set; }
        // public ВОПРОС: как задать массив для графика, с датами и со скоростью
    }
}
