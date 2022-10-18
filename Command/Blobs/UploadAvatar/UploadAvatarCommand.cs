using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Blobs.UploadAvatar
{
    public class UploadAvatarCommand : IRequest<string>
    {
        public int UserId { get; set; } // УБРАТЬ
        public IFormFile Files { get; set; }
    }
}
