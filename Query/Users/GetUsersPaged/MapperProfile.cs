using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Users.GetUsersPaged
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, PagedUsersDto>();
            CreateMap<IEnumerable<User>, IEnumerable<PagedUsersDto>>();
        }
    }
}
