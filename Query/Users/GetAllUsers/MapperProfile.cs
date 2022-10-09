using AutoMapper;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Users.GetAllUsers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserDto>();
            //CreateMap<IEnumerable<User>, IEnumerable<UserDto>>();
            //this.CreateMap<FitnessProgram, FitnessProgramViewModel>()
            //    .ForMember(x => x.Type, y => y.MapFrom(z => z.FitnessType));
        }
    }
}


