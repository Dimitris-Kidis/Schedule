using MediatR;

namespace Query.Texts.GetRandomTextByLanguage
{
    public class GetRandomTextByLanguageQuery : IRequest<TextDto>
    {
        public string Language { get; set; }
    }
}
