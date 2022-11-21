using ApplicationCore.Services.Repository;
using AutoMapper;
using MediatR;

namespace Query.StatisticsAVG.GetAverageDataById
{
    public class GetAverageDataByIdQueryHandler : IRequestHandler<GetAverageDataByIdQuery, AverageDataDto>
    {
        private readonly ITypoRepository<ApplicationCore.Domain.Entities.StatisticsAVG> _statsAVGRepository;
        private readonly IMapper _mapper;
        public GetAverageDataByIdQueryHandler(ITypoRepository<ApplicationCore.Domain.Entities.StatisticsAVG> statsAVGRepository, IMapper mapper)
        {
            _statsAVGRepository = statsAVGRepository;
            _mapper = mapper;
        }
        public async Task<AverageDataDto> Handle(GetAverageDataByIdQuery request, CancellationToken cancellationToken)
        {
            var text = _statsAVGRepository.GetWithInclude(x => x.Id == request.Id);

            return _mapper.Map<AverageDataDto>(text);
        }
    }
}
