using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Users.GetInfoForDashboard
{
    public class DashboardInfoDto
    {
        public int Id { get; set; }
        public bool IsAdmin { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[]? Avatar { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}
