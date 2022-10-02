using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.ViewModels
{
    public class AllUsersForAdminViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }   
        public string? Avatar { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public bool IsAdmin { get; set; }
    }
}
