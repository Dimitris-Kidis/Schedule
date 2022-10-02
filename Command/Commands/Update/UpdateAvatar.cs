using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands.Update
{
    public class UpdateAvatar : IRequest
    {
        public int Id { get; set; } // ВОПРОС: Id или Avatar
    }
}
