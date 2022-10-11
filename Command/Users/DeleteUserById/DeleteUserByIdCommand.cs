using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Users.DeleteUserById
{
    public class DeleteUserByIdCommand : IRequest
    {
        public int Id { get; set; }
    }
}
