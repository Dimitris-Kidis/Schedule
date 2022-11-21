using MediatR;

namespace Query.StatisticsAVG.GetAverageDataById
{
    public class GetAverageDataByIdQuery : IRequest<AverageDataDto>
    {
        public int Id { get; set; }
    }
}
