﻿using ApplicationCore.Services.Repository;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Statistics.GetStatisticsById
{
    public class GetStatisticsByIdQueryHandler : IRequestHandler<GetStatisticsByIdQuery, IEnumerable<StatisticsDto>>
    {
        private readonly ITypoRepository<ApplicationCore.Domain.Entities.Statistics> _statsRepository;
        private readonly IMapper _mapper;
        public GetStatisticsByIdQueryHandler(ITypoRepository<ApplicationCore.Domain.Entities.Statistics> statsRepository, IMapper mapper)
        {
            _statsRepository = statsRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<StatisticsDto>> Handle(GetStatisticsByIdQuery request, CancellationToken cancellationToken)
        {
            var stats = _statsRepository.GetListWithInclude(x => x.UserId == request.Id);

            //return _mapper.Map<IEnumerable<StatisticsDto>>(user);;
            return stats.Select(_mapper.Map<StatisticsDto>);
        }
    }
}
