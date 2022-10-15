namespace TYPO.Controllers.Statistics.ViewModels
{
    public class StatisticsViewModel
    {
        public int SymbolsPerMinute { get; set; }
        public int Accuracy { get; set; }
        public int NumberOfMistakes { get; set; }
        public string? SharedVia { get; set; }
        public int UserId { get; set; }
    }
}
