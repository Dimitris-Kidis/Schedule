using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Blobs.UploadPersonalAvatar
{
    public class UploadPersonalAvatarCommandValidator : AbstractValidator<UploadPersonalAvatarCommand>
    {
        public UploadPersonalAvatarCommandValidator()
        {
            RuleFor(avatar => avatar.Files)
                .NotEmpty()
                .Must(a => a.ContentType == "image/png" || a.ContentType == "image/jpeg").WithMessage($"Avatar format should be either .png or .jpeg.");
        }
    }
}
