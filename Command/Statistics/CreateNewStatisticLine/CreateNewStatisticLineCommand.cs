using MediatR;

namespace Command.Statistics.CreateNewStatisticLine
{
    public class CreateNewStatisticLineCommand : IRequest<int>
    {
        public int UserId { get; set; }
        public int TextId { get; set; }
        public float SymbolsPerMinute { get; set; }
        public float Accuracy { get; set; }
        public string Time { get; set; } = null!;
        public int NumberOfMistakes { get; set; }
        public string? SharedVia { get; set; }
    }
}
