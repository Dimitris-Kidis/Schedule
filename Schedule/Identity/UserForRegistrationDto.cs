﻿using System.ComponentModel.DataAnnotations;

namespace TYPO.Identity
{
    public class UserForRegistrationDto
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
