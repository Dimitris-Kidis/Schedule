using MediatR;

namespace Query.Texts.GetTextById
{
    public class GetTextByIdQuery : IRequest<GetTextByIdDto>
    {
        public int Id { get; set; }
    }
}
