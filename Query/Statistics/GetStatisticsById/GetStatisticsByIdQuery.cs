using MediatR;

namespace Query.Statistics.GetStatisticsById
{
    public class GetStatisticsByIdQuery : IRequest<IEnumerable<StatisticsDto>>
    {
        public int Id { get; set; }
    }
}
