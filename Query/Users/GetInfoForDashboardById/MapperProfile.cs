using AutoMapper;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Users.GetInfoForDashboard
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, DashboardInfoDto>();
        }
    }
}
