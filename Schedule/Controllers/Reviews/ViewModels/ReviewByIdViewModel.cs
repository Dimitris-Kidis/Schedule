namespace TYPO.Controllers.Reviews.ViewModels
{
    public class ReviewByIdViewModel
    {
        public int Id { get; set; }
        public string ReviewContent { get; set; }
        public int TextId { get; set; }
        public int UserId { get; set; }
    }
}
