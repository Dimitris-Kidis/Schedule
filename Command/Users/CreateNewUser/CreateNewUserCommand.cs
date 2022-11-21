﻿using MediatR;

namespace Command.Users.CreateNewUser
{
    public class CreateNewUserCommand : IRequest<int>
    {
        public bool IsAdmin { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}
