using MediatR;
using Query.ViewModels;

namespace Query.Users.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<IEnumerable<UserDto>>
    {
    }
}
