namespace Schedule_Project.ApplicationCore.Domain.Entities
{
    public class Client : BaseEntity
    {
        public string Interests { get; set; }
        public User User { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
    }
}
