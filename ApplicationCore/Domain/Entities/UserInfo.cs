using ApplicationCore.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using TYPO.ApplicationCore.Domain.Entities;

namespace TYPO.ApplicationCore.Domain.Entities
{
    public class UserInfo : BaseEntity
    {
        public DateTime SignUpAt { get; set; }
        public int ThemeId { get; set; }
        
        public string Language { get; set; }
        public User User { get; set; }

    }
}