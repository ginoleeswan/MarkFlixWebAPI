namespace MarkFlixWebAPI.Models.RecentlyAdded
{

    public class GetRecentlyAddedResult
    {
        public Response response { get; set; }
    }

    public class Response
    {
        public string result { get; set; }
        public object message { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public Recently_Added[] recently_added { get; set; }
    }

    public class Recently_Added
    {
        public string media_type { get; set; }
        public string section_id { get; set; }
        public string library_name { get; set; }
        public string rating_key { get; set; }
        public string parent_rating_key { get; set; }
        public string grandparent_rating_key { get; set; }
        public string title { get; set; }
        public string parent_title { get; set; }
        public string grandparent_title { get; set; }
        public string original_title { get; set; }
        public string sort_title { get; set; }
        public string media_index { get; set; }
        public string parent_media_index { get; set; }
        public string studio { get; set; }
        public string content_rating { get; set; }
        public string summary { get; set; }
        public string tagline { get; set; }
        public string rating { get; set; }
        public string rating_image { get; set; }
        public string audience_rating { get; set; }
        public string audience_rating_image { get; set; }
        public string user_rating { get; set; }
        public string duration { get; set; }
        public string year { get; set; }
        public string thumb { get; set; }
        public string parent_thumb { get; set; }
        public string grandparent_thumb { get; set; }
        public string art { get; set; }
        public string banner { get; set; }
        public string originally_available_at { get; set; }
        public string added_at { get; set; }
        public string updated_at { get; set; }
        public string last_viewed_at { get; set; }
        public string guid { get; set; }
        public string[] directors { get; set; }
        public string[] writers { get; set; }
        public string[] actors { get; set; }
        public string[] genres { get; set; }
        public object[] labels { get; set; }
        public object[] collections { get; set; }
        public string[] guids { get; set; }
        public string full_title { get; set; }
        public string child_count { get; set; }
    }

}
