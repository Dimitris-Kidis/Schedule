using AutoMapper;

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
