namespace Query.Texts.GetTextById
{
    public class GetTextByIdDto
    {
        public int Id { get; set; }
        public string TextContent { get; set; }
        public string Author { get; set; }
        public int Level { get; set; }
        public string Language { get; set; }
    }
}
