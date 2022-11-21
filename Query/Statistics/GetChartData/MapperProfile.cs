using AutoMapper;

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
