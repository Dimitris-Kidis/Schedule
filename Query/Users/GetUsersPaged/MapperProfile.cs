using AutoMapper;
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
