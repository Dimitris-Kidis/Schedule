using System.ComponentModel.DataAnnotations.Schema;

namespace Schedule_Project.ApplicationCore.Domain.Entities
{
    public class Schedule
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int SpecialistId { get; set; }
        public Specialist Specialist { get; set; }
        public int ScheduleId { get; set; }
        public string MeetingDate { get; set; }
        public string MeetingTime { get; set; }
    }
}
