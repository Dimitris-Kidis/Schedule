using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Statistics.DeleteAllStatisticsById
{
    public class DeleteAllStatisticsByIdCommand : IRequest
    {
        public int Id { get; set; }
    }
}
