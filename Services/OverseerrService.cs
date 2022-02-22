using MarkFlixWebAPI.Models;
using MarkFlixWebAPI.Models.Overseerr.Requests;
using MarkFlixWebAPI.Models.Overseerr.Users;
using System.Text.Json;

namespace MarkFlixWebAPI.Services
{
    public class OverseerrService : IOverseerrService
    {
        private readonly HttpClient _httpClient;
        private readonly ITheMovieDBService _theMovieDBService;

        public OverseerrService(HttpClient httpClient, ITheMovieDBService theMovieDBService)
        {
            _httpClient = httpClient;
            _theMovieDBService = theMovieDBService;
        }
        public async Task<IEnumerable<User>?> GetUsers()
        {   
            var response = await _httpClient.GetAsync("user?take=100&skip=0&sort=requests");

            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();
            var responseObject = await JsonSerializer.DeserializeAsync<GetOverseerrUsersResult>(responseStream);

            return responseObject?.results.Select(i => new User
            {
                UserId = i.id,
                Name = i.displayName,
                Email = i.email,
                RequestCount = i.requestCount,
                UserThumb = i.avatar, 
            });
        }

        public async Task<IEnumerable<Request>?> GetRequests(int? id)
        {
            var response = await _httpClient.GetAsync($"user/{id}/requests?take=100&skip=0");

            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();
            var responseObject = await JsonSerializer.DeserializeAsync<GetOverseerrUserRequestsResult>(responseStream);

            // List<Request> requestList = new List<Request>();



            //foreach (var request in responseObject?.results)
            // {
            //     var requestObject = new Request
            //     {
            //         Id = request.id,
            //         Type = request.type,
            //         Name = request.media.externalServiceSlug,
            //         ContentKey = request.media.ratingKey,
            //         TmdbID = request.media.tmdbId

            //     };

            //     requestList.Add(requestObject);
            // }

            //foreach(var request in requestList)
            // {
            //     request.Artwork = _theMovieDBService.GetArtwork(request.TmdbID, request.Type).Result;
            // }

            //return requestList;

            return responseObject?.results.Select(i => new Request
            {
                Id = i.media.id,
                RequesterName = i.requestedBy.plexUsername,
                Type = i.type,
                Name = _theMovieDBService.GetName(i.media.tmdbId, i.type).Result,
                ContentKey = i.media.ratingKey,
                TmdbID = i.media.tmdbId,
                Artwork = String.Format("https://image.tmdb.org/t/p/w500{0}", _theMovieDBService.GetArtwork(i.media.tmdbId, i.type).Result)
            });



        }
    }
}
