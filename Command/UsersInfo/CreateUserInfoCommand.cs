using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace Command.UsersInfo
{
    public class CreateUserInfoCommand : IRequest<int>
    {
        public int Id { get; set; } // ВОПРОС ПРО АЙДИ
        public int ThemeId { get; set; }
        public int Language { get; set; }
    }
}
