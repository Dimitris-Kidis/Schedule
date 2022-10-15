using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.UserInfo.PartialUpdateLanguageById
{
    
    public class PartialUpdateUserInfoLanguageByIdCommandValidator : AbstractValidator<PartialUpdateUserInfoLanguageByIdCommand>
    {
        public PartialUpdateUserInfoLanguageByIdCommandValidator()
        {
            var languageCondotions = new List<string>() { "Russian", "English", "Romanian" };
            RuleFor(stats => stats.Id).NotEmpty();
            RuleFor(stats => stats.Language).NotEmpty().Must(confitions => languageCondotions.Contains(confitions));
        }
    }
}
