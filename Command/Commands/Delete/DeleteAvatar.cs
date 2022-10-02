using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands.Delete
{
    public class DeleteAvatar : IRequest
    {
        public int id { get; set; }
    }
}
