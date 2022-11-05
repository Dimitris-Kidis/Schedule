﻿using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Blobs.UploadPersonalAvatar
{
    public class UploadPersonalAvatarCommand : IRequest<string>
    {
        public IFormFile Files { get; set; }
    }
}