using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.UserInfo.PartialUpdateLanguageById
{
    public class PartialUpdateUserInfoLanguageByIdCommand : IRequest
    {
        public int Id { get; set; }
        public string Language { get; set; }
    }
}
