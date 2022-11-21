namespace Query.Reviews.GetReviewsPaged
{
    public class GetPagedReviewsDto
    {
        public int Id { get; set; }
        public string ReviewContent { get; set; }
        public string UserEmail { get; set; }
        public string TextContent { get; set; }
    }

}
