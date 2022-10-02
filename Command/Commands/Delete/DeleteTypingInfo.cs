using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands.Delete
{
    public class DeleteTypingInfo : IRequest
    {
        public int Id { get; set; }
    }
}
