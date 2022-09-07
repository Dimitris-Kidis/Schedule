namespace Schedule.ApplicationCore.Domain.Entities
{
    public class Reviews : BaseEntity
    {
        public int ClientId { get; set; }
        public int SpecialistId { get; set; }
        public string ReviewText { get; set; } = string.Empty;
        public int Stars { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
    }
}
