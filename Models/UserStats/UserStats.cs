namespace MarkFlixWebAPI.Models.UserStats
{
    public class UserStats
    {
        public string PlayerName { get; set; }
        public string Platform { get; set; }
        public string PlatformName { get; set; }
        public int totalPlays { get; set; }
        public int totalTime { get; set; }
        public int resultId { get; set; }
    }
}
