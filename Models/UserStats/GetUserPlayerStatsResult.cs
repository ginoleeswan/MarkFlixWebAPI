namespace MarkFlixWebAPI.Models.UserStats
{
    public class GetUserPlayerStatsResults
    {
        public Response response { get; set; }
    }

    public class Response
    {
        public string result { get; set; }
        public object message { get; set; }
        public Datum[] data { get; set; }
    }

    public class Datum
    {
        public string player_name { get; set; }
        public string platform { get; set; }
        public string platform_name { get; set; }
        public int total_plays { get; set; }
        public int total_time { get; set; }
        public int result_id { get; set; }
    }

}
