﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Statistics.CreateNewStatisticLine
{
    public class CreateNewStatisticLineCommand : IRequest<int>
    {
        public int UserId { get; set; }
        public int TextId { get; set; }
        public int SymbolsPerMinute { get; set; }
        public int Accuracy { get; set; }
        public int NumberOfMistakes { get; set; }
        public string? SharedVia { get; set; }
    }
}
