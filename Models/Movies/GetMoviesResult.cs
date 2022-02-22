namespace MarkFlixWebAPI.Models.Movies
{

    public class GetMoviesResult
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
        public string stat_id { get; set; }
        public string stat_type { get; set; }
        public string stat_title { get; set; }
        public Row[] rows { get; set; }
    }

    public class Row
    {
        public string title { get; set; }
        public int year { get; set; }
        public int total_plays { get; set; }
        public int total_duration { get; set; }
        public object users_watched { get; set; }
        public object rating_key { get; set; }
        public object grandparent_rating_key { get; set; }
        public int last_play { get; set; }
        public string grandparent_thumb { get; set; }
        public string thumb { get; set; }
        public string art { get; set; }
        public int section_id { get; set; }
        public string media_type { get; set; }
        public string content_rating { get; set; }
        public object[] labels { get; set; }
        public string user { get; set; }
        public string friendly_name { get; set; }
        public string platform { get; set; }
        public int live { get; set; }
        public string guid { get; set; }
        public object row_id { get; set; }
        public int user_id { get; set; }
        public string user_thumb { get; set; }
        public string grandparent_title { get; set; }
        public string grandchild_title { get; set; }
        public int media_index { get; set; }
        public int parent_media_index { get; set; }
        public int last_watch { get; set; }
        public string player { get; set; }
        public string section_type { get; set; }
        public string section_name { get; set; }
        public string platform_name { get; set; }
        public int count { get; set; }
        public string started { get; set; }
        public string stopped { get; set; }
    }

}
