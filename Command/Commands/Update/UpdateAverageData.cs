using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands.Update
{
    public class UpdateAverageData : IRequest
    {
        public int Id { get; set; }
        public float AvgSymbolsPerMin { get; set; }
        public float AvgAccuracy { get; set; }
        public float AvgTime { get; set; }
    }
}
