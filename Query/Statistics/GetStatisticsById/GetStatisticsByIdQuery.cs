using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Statistics.GetStatisticsById
{
    public class GetStatisticsByIdQuery : IRequest<IEnumerable<StatisticsDto>>
    {
        public int Id { get; set; }
    }
}
