using MediatR;

namespace Command.Texts.UpdateText
{
    public class UpdateTextCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string TextContent { get; set; }
        public string Author { get; set; }
        public int Level { get; set; }
        public string Language { get; set; }
    }
}
