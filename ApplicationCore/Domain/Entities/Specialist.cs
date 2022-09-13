namespace Schedule_Project.ApplicationCore.Domain.Entities
{
    public class Specialist : BaseEntity
    {
        public string Domain { get; set; }
        public string WorkExperience { get; set; }
        public User User { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
    }
}
