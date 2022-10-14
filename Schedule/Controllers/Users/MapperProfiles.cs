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
            CreateMap<IEnumerable<UserDto>, IEnumerable<AllUsersForAdminViewModel>>();

            CreateMap<UserDto, AllUsersForAdminViewModel>();

            CreateMap<DashboardInfoDto, GetInfoForDashboardViewModel>();


        }
    }
}
