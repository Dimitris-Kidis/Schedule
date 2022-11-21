using MediatR;

namespace Command.StatisticsAVG.UpdateAverageStatistics
{
    public class UpdateAverageStatisticsCommand : IRequest<int>
    {
        public int Id { get; set; }
        public float AvgSymbolsPerMin { get; set; }
        public float AvgAccuracy { get; set; }
        public string AvgTime { get; set; }
        public int TextsCount { get; set; }
    }
}
