﻿using AutoMapper;
using Query.Statistics.GetChartData;
using Query.Users.GetAllUsers;
using Query.Users.GetInfoForDashboard;
using Query.Users.GetUsersPaged;
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

            CreateMap<IEnumerable<PagedUsersDto>, IEnumerable<AllUsersForAdminViewModel>>();

            CreateMap<ChartDataDto, ChartDataViewModel>();
            CreateMap<IEnumerable<ChartDataDto>, IEnumerable<ChartDataViewModel>>();
        }
    }
}
