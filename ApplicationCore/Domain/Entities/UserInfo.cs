using ApplicationCore.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using TYPO.ApplicationCore.Domain.Entities;

namespace ApplicationCore.Domain.Entities
{
    public class UserInfo : BaseEntity
    {
        public DateTime SignUpAt { get; set; }
        public string? ThemeColors { get; set; }
        public string Language { get; set; }
        public User User { get; set; }

    }
}