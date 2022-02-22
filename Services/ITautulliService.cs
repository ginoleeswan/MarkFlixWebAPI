using MarkFlixWebAPI.Models;
using MarkFlixWebAPI.Models.Movies;
using MarkFlixWebAPI.Models.UserStats;
using System.Web.Http;

namespace MarkFlixWebAPI.Services
{
    public interface ITautulliService
    {
        Task<IEnumerable<User>> GetUsers();
        Task<IEnumerable<HomeStat>> GetHomeStats();
        Task<IEnumerable<Movie>> GetRecentlyAdded();
        Task<IEnumerable<UserStats>> GetUserPlayerStats(string userId);
        Task<IEnumerable<Library>> GetLibraries();
        Task<IEnumerable<User>> GetLibraryUserStats(int sectionId);
    }
}
