using MediatR;

namespace Command.UserInfo.PartialUpdateThemeById
{
    public class PartialUpdateUserInfoThemeByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string ThemeColors { get; set; }
    }
}
