using ApplicationCore.Services.Repository.UserRepository;
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
            CreateMap<User, GetUsersAndStatsAvgPagedDto>();

            CreateMap<IEnumerable<User>, IEnumerable<GetUsersAndStatsAvgPagedDto>>();

            CreateMap<UsersAvgStats, GetUsersAndStatsAvgPagedDto>();

        }
    }
}
