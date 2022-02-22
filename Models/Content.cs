namespace MarkFlixWebAPI.Models.Movies
{
    public class Movie
    {
        public string Title { get; set; }
        public string ParentTitle { get; set; }
        public string OriginalTitle { get; set; }
        public string[] Guids { get; set; }
        public int Year { get; set; }
        public int TotalPlays { get; set; }
        public string Artwork { get; set; }
        public string MediaType { get; set; }
        public string ContentRating { get; set; }
        public string WasWatched { get; set; }
        public string LibraryName { get; set; }


    }
}
