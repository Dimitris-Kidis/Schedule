using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Texts.DeleteTextById
{
    public class DeleteTextByIdCommand : IRequest
    {
        public int Id { get; set; }
    }
}
