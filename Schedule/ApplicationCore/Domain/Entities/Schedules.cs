namespace Schedule.ApplicationCore.Domain.Entities
{
    public class Schedules : BaseEntity
    {
        public int ClientId { get; set; }
        public int SpecialistId { get; set; }
        public int ScheduleId { get; set; }
        public DateOnly MeetingDate { get; set; }
        public TimeOnly MeetingTime { get; set; }
    }
}
