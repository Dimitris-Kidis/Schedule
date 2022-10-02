namespace TYPO.Hometask_3.Dtos
{
    public class TextDto
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTimeOffset CreatedAt { get; set; }
        public string TextContent { get; set; }
        public string Author { get; set; }
        public int Level { get; set; }
    }
}
