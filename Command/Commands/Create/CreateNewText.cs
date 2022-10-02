using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands.Create
{
    public class CreateNewText : IRequest<int>
    {
        public int TextId { get; set; }
        public string TextContent { get; set; }
        public string Author { get; set; }

    }
}
