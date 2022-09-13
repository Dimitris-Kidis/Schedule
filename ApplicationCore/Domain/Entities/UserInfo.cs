using System.ComponentModel.DataAnnotations.Schema;

namespace Schedule_Project.ApplicationCore.Domain.Entities
{
    public class UserInfo : BaseEntity
    {
        [Column(TypeName = "Date")]
        public DateTime SignUpAt { get; set; }
        public string SearchHistory { get; set; }
        public int NumberOfMeetings { get; set; }
        //public User User { get; set; }

    }
}