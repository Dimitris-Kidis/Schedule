using AutoMapper;
using Query.Users.GetAllUsers;
using Query.Users.GetInfoForDashboard;
using TYPO.Controllers.Users.ViewModels;

namespace TYPO.Controllers.Users
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            //CreateMap<UserDto, AllUsersForAdminViewModel>()
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            //CreateMap<IEnumerable<UserDto>, IEnumerable<AllUsersForAdminViewModel>>();
            CreateMap<UserDto, AllUsersForAdminViewModel>();
            CreateMap<IEnumerable<UserDto>, IEnumerable<AllUsersForAdminViewModel>>();

            CreateMap<DashboardInfoDto, GetInfoForDashboardViewModel>();


        }
    }
}
