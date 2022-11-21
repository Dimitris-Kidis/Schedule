namespace Query.Users.GetUsersPaged
{
    public class PagedUsersDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? Avatar { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public bool IsAdmin { get; set; }
    }
}
