using ApplicationCore.Services.Repository;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Statistics.GetChartData
{
    public class GetChartDataQueryHandler : IRequestHandler<GetChartDataQuery, IEnumerable<ChartDataDto>>
    {
        private readonly ITypoRepository<ApplicationCore.Domain.Entities.Statistics> _statisticsRepository;
        private readonly IMapper _mapper;
        public GetChartDataQueryHandler(ITypoRepository<ApplicationCore.Domain.Entities.Statistics> statisticsRepository, IMapper mapper)
        {
            _statisticsRepository = statisticsRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ChartDataDto>> Handle(GetChartDataQuery request, CancellationToken cancellationToken)
        {
            var result = await _statisticsRepository
            .GetAll()
            .Where(user => user.UserId == request.Id)
            .Select(statistic => new ChartDataDto
            {
                SymbolsPerMinute = statistic.SymbolsPerMinute,
                Date = statistic.CreatedAt
            })
            .ToListAsync(cancellationToken);
            return result.Select(_mapper.Map<ChartDataDto>);
            //var result =  _statisticsRepository.GetAll().Where(user => user.id);
            //result = result.Where(user => user.UserId == request.Id);
            //result = (IQueryable<ApplicationCore.Domain.Entities.Statistics>)result.Select(statistic => new ChartDataDto
            //{
            //    SymbolsPerMinute = statistic.SymbolsPerMinute,
            //    Date = statistic.CreatedAt
            //});

            //return result.Select(_mapper.Map<ChartDataDto>);
            //return result.Select(_mapper<ChartDataDto>) ;
        }
            
    }
}
