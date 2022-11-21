namespace Query.Reviews.GetAllReviews
{
    public class ReviewDto
    {
        public int Id { get; set; }
        public string ReviewContent { get; set; }
        public int UserId { get; set; }
        public int TextId { get; set; }
        public string TextContent { get; set; }
        
    }
}
