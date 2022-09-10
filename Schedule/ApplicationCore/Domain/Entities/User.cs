namespace Schedule_Project.ApplicationCore.Domain.Entities
{
    public class User : BaseEntity
    {
        public bool IsClient { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string ProfilePic { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public UserInfo UserInfo { get; set; }
        public Client Client { get; set; }
        public Specialist Specialist { get; set; }

    }
}
