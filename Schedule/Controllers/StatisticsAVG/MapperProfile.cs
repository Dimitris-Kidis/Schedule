using AutoMapper;
using Query.StatisticsAVG.GetAverageDataById;
using TYPO.Controllers.StatisticsAVG.ViewModels;

namespace TYPO.Controllers.StatisticsAVG
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AverageDataDto, StatisticsAVGViewModel>();
        }
    }
}
