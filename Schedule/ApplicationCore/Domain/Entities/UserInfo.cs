namespace Schedule.ApplicationCore.Domain.Entities
{
    public class UserInfo : BaseEntity
    {
        public DateTime SignUpAt { get; set; }
        public string[] SearchHistory { get; set; }
        public int NumberOfMeetings { get; set; }

    }
}
