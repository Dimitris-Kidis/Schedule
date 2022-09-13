using System.ComponentModel.DataAnnotations.Schema;

namespace Schedule_Project.ApplicationCore.Domain.Entities
{
    public class Review
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int SpecialistId { get; set; }
        public Specialist Specialist { get; set; }
        public string ReviewText { get; set; } = string.Empty;
        public int Stars { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
