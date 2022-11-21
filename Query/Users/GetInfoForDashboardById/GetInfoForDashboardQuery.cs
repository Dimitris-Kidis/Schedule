using MediatR;

namespace Query.Users.GetInfoForDashboard
{
    public class GetInfoForDashboardQuery : IRequest<DashboardInfoDto> 
    {
        public int Id { get; set; }
    }
}
