namespace MarkFlixWebAPI.Models
{
    public class Request
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string ContentKey { get; set; }
        public string Artwork { get; set; }
        public int TmdbID { get; set; }
        public string RequesterName { get; set; }
    }
}
