using MediatR;
using Query.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Queries
{
    public class GetDataForChartQuery : IRequest<ChartDataViewModel>
    {
        public int Id { get; set; }
    }
}
