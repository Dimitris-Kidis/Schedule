using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Statistics.GetStatisticsById
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ApplicationCore.Domain.Entities.Statistics, StatisticsDto>();
            CreateMap<IEnumerable<ApplicationCore.Domain.Entities.Statistics>, IEnumerable<StatisticsDto>>();
        }
    }
}
