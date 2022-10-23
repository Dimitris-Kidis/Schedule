using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Statistics.GetChartData
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ApplicationCore.Domain.Entities.Statistics, ChartDataDto>();
            CreateMap<IEnumerable<ApplicationCore.Domain.Entities.Statistics>, IEnumerable<ChartDataDto>>();
        }
    }
}
