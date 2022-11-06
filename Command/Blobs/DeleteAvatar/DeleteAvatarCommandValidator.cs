using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Blobs.DeleteAvatar
{
    public class DeleteAvatarCommandValidator : AbstractValidator<DeleteAvatarCommand>
    {
        public DeleteAvatarCommandValidator()
        {
            RuleFor(avatar => avatar.UserId)
                .NotEmpty();
        }
    }
}
