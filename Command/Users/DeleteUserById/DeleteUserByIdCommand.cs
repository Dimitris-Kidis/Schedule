using MediatR;

namespace Command.Users.DeleteUserById
{
    public class DeleteUserByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
