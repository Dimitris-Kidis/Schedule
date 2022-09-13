namespace Schedule_Project.ApplicationCore.Domain.Entities
{
    public class Service : BaseEntity
    {
        public Specialist Specialist { get; set; }
        public string ServiceName { get; set; }
        public decimal Price { get; set; }
        public string Duration { get; set; }
    }
}
