using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Statistics.CreateNewStatisticLine
{
    public class CreateNewStatisticLineCommandValidator : AbstractValidator<CreateNewStatisticLineCommand>
    {
        public CreateNewStatisticLineCommandValidator()
        {
            RuleFor(line => line.UserId).NotEmpty();
            RuleFor(line => line.TextId).NotEmpty();
            RuleFor(line => line.SymbolsPerMinute).NotEmpty();
            RuleFor(line => line.Accuracy).NotEmpty();
            RuleFor(line => line.NumberOfMistakes).NotEmpty();
        }
    }
}
