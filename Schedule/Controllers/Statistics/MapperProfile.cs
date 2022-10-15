using AutoMapper;
using Query.Statistics.GetStatisticsById;
using TYPO.Controllers.Statistics.ViewModels;

namespace TYPO.Controllers.Statistics
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<IEnumerable<StatisticsDto>, IEnumerable<StatisticsViewModel>>();

            CreateMap<StatisticsDto, StatisticsViewModel>();

        }
    }
}
