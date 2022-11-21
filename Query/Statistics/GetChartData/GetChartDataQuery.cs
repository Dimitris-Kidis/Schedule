using MediatR;

namespace Query.Statistics.GetChartData
{
    public class GetChartDataQuery : IRequest<IEnumerable<ChartDataDto>>
    {
        public int Id { get; set; }
    }
}
