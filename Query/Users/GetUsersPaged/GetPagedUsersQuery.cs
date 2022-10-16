using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Users.GetUsersPaged
{
    public class GetPagedUsersQuery : IRequest<IEnumerable<PagedUsersDto>>
    {
    }
}
