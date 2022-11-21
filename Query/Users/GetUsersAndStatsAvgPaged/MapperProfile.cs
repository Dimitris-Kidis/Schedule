using AutoMapper;

namespace Query.Users.GetUsersAndStatsAvgPaged
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AverageDataDto, GetUsersAndStatsAvgPagedDto>();

            CreateMap<IEnumerable<AverageDataDto>, IEnumerable<GetUsersAndStatsAvgPagedDto>>();
        }
    }
}
