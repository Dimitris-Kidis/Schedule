using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Users.GetUsersAndStatsAvgPaged
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //CreateMap<User, UserDto>();

            //CreateMap<IEnumerable<User>, IEnumerable<UserDto>>();

            //CreateMap<ApplicationCore.Domain.Entities.StatisticsAVG, AverageDataDto>();

            //CreateMap<IEnumerable<ApplicationCore.Domain.Entities.StatisticsAVG>, IEnumerable<AverageDataDto>>();

            CreateMap<AverageDataDto, GetUsersAndStatsAvgPagedDto>();

            CreateMap<IEnumerable<AverageDataDto>, IEnumerable<GetUsersAndStatsAvgPagedDto>>();
        }
    }
}
