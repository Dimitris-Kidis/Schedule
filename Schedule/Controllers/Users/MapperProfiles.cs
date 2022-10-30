using AutoMapper;
using FitnessWeb.API.Identity;
using Query.Statistics.GetChartData;
using Query.Users.GetAllUsers;
using Query.Users.GetInfoForDashboard;
using Query.Users.GetUsersPaged;
using TYPO.ApplicationCore.Domain.Entities;
using TYPO.Controllers.Users.ViewModels;
using TYPO.Identity;

namespace TYPO.Controllers.Users
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<IEnumerable<UserDto>, IEnumerable<AllUsersForAdminViewModel>>();

            CreateMap<UserDto, AllUsersForAdminViewModel>();

            CreateMap<DashboardInfoDto, GetInfoForDashboardViewModel>();

            CreateMap<IEnumerable<PagedUsersDto>, IEnumerable<AllUsersForAdminViewModel>>();

            CreateMap<ChartDataDto, ChartDataViewModel>();
            CreateMap<IEnumerable<ChartDataDto>, IEnumerable<ChartDataViewModel>>();

            //CreateMap<UserForRegistrationDto, User>()   УБРАТЬ
            //    .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email))
            //    .ForMember(u => u.CreatedBy, opt => opt.MapFrom(x => x.Email));
                
        }
    }
}
