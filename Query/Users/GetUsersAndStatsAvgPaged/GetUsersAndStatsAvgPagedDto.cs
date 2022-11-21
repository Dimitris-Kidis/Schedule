namespace Query.Users.GetUsersAndStatsAvgPaged
{
    public class GetUsersAndStatsAvgPagedDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float AvgSymbolsPerMin { get; set; }
        public float AvgAccuracy { get; set; }
        public string AvgTime { get; set; }
    }
}
