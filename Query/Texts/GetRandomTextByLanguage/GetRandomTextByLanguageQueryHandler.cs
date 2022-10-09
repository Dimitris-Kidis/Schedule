using ApplicationCore.Domain.Entities;
using ApplicationCore.Services.Repository;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Texts.GetRandomTextByLanguage
{
    public class GetRandomTextByLanguageQueryHandler : IRequestHandler<GetRandomTextByLanguageQuery, TextDto>
    {
        private readonly ITypoRepository<Text> _textRepository;
        private readonly IMapper _mapper;
        public GetRandomTextByLanguageQueryHandler(ITypoRepository<Text> textRepository, IMapper mapper)
        {
            _textRepository = textRepository;
            _mapper = mapper;
        }
        public async Task<TextDto> Handle(GetRandomTextByLanguageQuery request, CancellationToken cancellationToken)
        {
            var text = _textRepository.GetWithInclude(x => x.Language == request.Language);


            return _mapper.Map<TextDto>(text);
        }
    }
}
