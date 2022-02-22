namespace MarkFlixWebAPI.Models.LibraryUserStats
{

    public class GetLibraryUserStatsResult
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
        public string friendly_name { get; set; }
        public int user_id { get; set; }
        public string user_thumb { get; set; }
        public string username { get; set; }
        public int total_plays { get; set; }
        public int total_time { get; set; }
    }

}
