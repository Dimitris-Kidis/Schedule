namespace Schedule.ApplicationCore.Domain.Entities
{
    public class Users : BaseEntity
    {
        public string Email { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string ProfilePic { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public enum GenderType
        {
            Male,
            Female
        }
    }
}
