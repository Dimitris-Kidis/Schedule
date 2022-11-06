using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Blobs.DeleteAvatar
{
    public class DeleteAvatarCommand : IRequest<string>
    {
        public int UserId { get; set; }
    }
}
