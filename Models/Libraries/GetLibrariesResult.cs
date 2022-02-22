namespace MarkFlixWebAPI.Models.Libraries
{

    public class GetLibrariesResult
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
        public string section_id { get; set; }
        public string section_name { get; set; }
        public string section_type { get; set; }
        public string agent { get; set; }
        public string thumb { get; set; }
        public string art { get; set; }
        public string count { get; set; }
        public int is_active { get; set; }
        public string parent_count { get; set; }
        public string child_count { get; set; }
    }

}
