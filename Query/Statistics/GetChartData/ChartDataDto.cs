﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Statistics.GetChartData
{
    public class ChartDataDto
    {
        public float SymbolsPerMinute { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
