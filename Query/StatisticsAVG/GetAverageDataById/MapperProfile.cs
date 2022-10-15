using AutoMapper;
using Query.StatisticsAVG.GetAverageDataById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.StatisticsAVG.GetAverageDataById
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ApplicationCore.Domain.Entities.StatisticsAVG, AverageDataDto>();
        }
    }
}
