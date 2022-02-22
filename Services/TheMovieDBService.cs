using MarkFlixWebAPI.Models.TheMovieDB;
using System.Text.Json;

namespace MarkFlixWebAPI.Services
{
    public class TheMovieDBService : ITheMovieDBService
    {
        private readonly HttpClient _httpClient;

        private string _apiKey = "3879bd1c26dd9ee50d4e4e01da21e6f0";

        public TheMovieDBService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string?> GetArtwork(int id, string type)
        {


                var apiString = $"/3/{type}/{id}?api_key={_apiKey}&language=en-US";
                var response = await _httpClient.GetAsync(apiString);
                response.EnsureSuccessStatusCode();

                using var responseStream = await response.Content.ReadAsStreamAsync();
                var responseObject = await JsonSerializer.DeserializeAsync<MovieDBSearchResult>(responseStream);

                return responseObject?.poster_path; 
            
        }

        public async Task<string?> GetName(int id, string type)
        {

            var apiString = $"/3/{type}/{id}?api_key={_apiKey}&language=en-US";
            var response = await _httpClient.GetAsync(apiString);
            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();
            var responseObject = await JsonSerializer.DeserializeAsync<MovieDBSearchResult>(responseStream);

            return (type == "tv" ? responseObject?.name : responseObject?.original_title);

        }


    }
}
