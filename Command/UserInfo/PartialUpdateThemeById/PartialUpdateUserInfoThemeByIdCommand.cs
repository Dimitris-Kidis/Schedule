using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.UserInfo.PartialUpdateThemeById
{
    public class PartialUpdateUserInfoThemeByIdCommand : IRequest
    {
        public int Id { get; set; }
        public string ThemeColors { get; set; }
    }
}
