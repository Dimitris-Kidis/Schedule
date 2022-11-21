using MediatR;

namespace Command.Texts.CreateNewText
{
    public class CreateNewTextCommand : IRequest<int>
    {
        public string TextContent { get; set; }
        public string Author { get; set; }
        public int Level { get; set; }
        public string Language { get; set; }
    }
}
