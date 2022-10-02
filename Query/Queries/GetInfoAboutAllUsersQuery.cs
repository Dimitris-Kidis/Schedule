using MediatR;
using Query.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Queries
{
    public class GetInfoAboutAllUsersQuery : IRequest<List<AllUsersForAdminViewModel>>
    {
    }
}
