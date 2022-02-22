namespace MarkFlixWebAPI.Services
{
    public interface ITheMovieDBService
    {
        Task<string> GetName(int id, string type);
        Task<string> GetArtwork(int id, string type);
    }
}
