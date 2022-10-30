using ApplicationCore.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TYPO.ApplicationCore.Domain.Entities
{
    public class User : IdentityUser<int>
    {
        public string CreatedBy { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? LastModifiedAt { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public bool IsAdmin { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public ICollection<Image> Images { get; set; }
        public UserInfo UserInfo { get; set; }
        public StatisticsAVG StatisticsAVG { get; set; }
        public ICollection<Statistics> Statistics { get; set; }

    }
}
