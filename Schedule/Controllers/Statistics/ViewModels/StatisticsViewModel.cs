namespace TYPO.Controllers.Statistics.ViewModels
{
    public class StatisticsViewModel
    {
        public float SymbolsPerMinute { get; set; }
        public string Time { get; set; } = null!;
        public float Accuracy { get; set; }
        public int NumberOfMistakes { get; set; }
        public string? SharedVia { get; set; }
        public int UserId { get; set; }
    }
}
