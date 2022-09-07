namespace Schedule.ApplicationCore.Domain.Entities
{
    public class Services : BaseEntity
    {
        public int ServiceId { get; set; }
        public int SpecialistId { get; set; }
        public string ServiceName { get; set; }
        public decimal Price { get; set; }
        public string Duration { get; set; }
    }
}
