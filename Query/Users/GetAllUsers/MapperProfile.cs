using AutoMapper;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Users.GetAllUsers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserDto>();
            //CreateMap<List<User>, List<UserDto>>();
        }
    }
}
