using MarkFlixWebAPI.Models.Movies;

namespace MarkFlixWebAPI.Models
{
    public class HomeStat
    {
        public string StatId { get; set; }
        public string StatTitle { get; set; }
        public Row[] Movies { get; set; }
    }
}
