using ApplicationCore.Domain.Entities;
using ApplicationCore.Services.Repository;
using AutoMapper;
using MediatR;

namespace Query.Texts.GetTextById
{
    public class GetTextByIdQueryHandler : IRequestHandler<GetTextByIdQuery, GetTextByIdDto>
    {
        private readonly ITypoRepository<Text> _textRepository;
        private readonly IMapper _mapper;
        public GetTextByIdQueryHandler(ITypoRepository<Text> textRepository, IMapper mapper)
        {
            _textRepository = textRepository;
            _mapper = mapper;
        }
        public async Task<GetTextByIdDto> Handle(GetTextByIdQuery request, CancellationToken cancellationToken)
        {
            var text = _textRepository.FindBy(x => x.Id == request.Id).FirstOrDefault();

            GetTextByIdDto dto = new()
            {
                Id = text.Id,
                TextContent = text.TextContent,
                Author = text.Author,
                Level = text.Level,
                Language = text.Language
            };

            return _mapper.Map<GetTextByIdDto>(text);
        }
    }
}
