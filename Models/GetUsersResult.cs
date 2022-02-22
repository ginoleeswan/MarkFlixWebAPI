namespace MarkFlixWebAPI.Models
{

    public class GetUsersResult
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
        public int recordsFiltered { get; set; }
        public int recordsTotal { get; set; }
        public Datum[] data { get; set; }
        public int draw { get; set; }
    }

    public class Datum
    {
        public int row_id { get; set; }
        public int user_id { get; set; }
        public string username { get; set; }
        public string friendly_name { get; set; }
        public string user_thumb { get; set; }
        public int plays { get; set; }
        public int duration { get; set; }
        public int? last_seen { get; set; }
        public string last_played { get; set; }
        public int? history_row_id { get; set; }
        public string ip_address { get; set; }
        public string platform { get; set; }
        public string player { get; set; }
        public int? rating_key { get; set; }
        public string media_type { get; set; }
        public string thumb { get; set; }
        public string parent_title { get; set; }
        public object year { get; set; }
        public object media_index { get; set; }
        public object parent_media_index { get; set; }
        public int? live { get; set; }
        public string originally_available_at { get; set; }
        public string guid { get; set; }
        public string transcode_decision { get; set; }
        public string do_notify { get; set; }
        public string keep_history { get; set; }
        public string allow_guest { get; set; }
        public int is_active { get; set; }
    }


}
