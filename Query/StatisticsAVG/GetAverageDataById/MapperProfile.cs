using AutoMapper;

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
