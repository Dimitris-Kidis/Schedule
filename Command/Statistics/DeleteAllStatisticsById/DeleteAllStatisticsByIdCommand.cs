using MediatR;

namespace Command.Statistics.DeleteAllStatisticsById
{
    public class DeleteAllStatisticsByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
