using MediatR;

namespace Command.UserInfo.PartialUpdateLanguageById
{
    public class PartialUpdateUserInfoLanguageByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Language { get; set; }
    }
}
