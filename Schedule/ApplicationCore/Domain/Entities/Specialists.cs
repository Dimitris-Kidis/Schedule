namespace Schedule.ApplicationCore.Domain.Entities
{
    public class Specialists : BaseEntity
    {
        public int UserId { get; set; }
        public string Domain { get; set; }
        public string WorkExperience { get; set; }
    }
}
