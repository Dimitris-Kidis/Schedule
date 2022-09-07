namespace Schedule.ApplicationCore.Domain.Entities
{
    public class Clients : BaseEntity
    {
        public int UserId { get; set; }
        public string[] Interests { get; set; }
    }
}
