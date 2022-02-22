using MarkFlixWebAPI.Models;

namespace MarkFlixWebAPI.Services
{
    public interface IOverseerrService
    {
        Task<IEnumerable<User>> GetUsers();
        Task<IEnumerable<Request>> GetRequests(int? id);
    }
}
