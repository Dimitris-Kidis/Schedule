using MediatR;

namespace Command.Texts.DeleteTextById
{
    public class DeleteTextByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
