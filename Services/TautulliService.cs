using MarkFlixWebAPI.Models;
using MarkFlixWebAPI.Models.Libraries;
using MarkFlixWebAPI.Models.LibraryUserStats;
using MarkFlixWebAPI.Models.Movies;
using MarkFlixWebAPI.Models.RecentlyAdded;
using MarkFlixWebAPI.Models.UserStats;
using MarkFlixWebAPI.Services;
using System.Text.Json;
using System.Web.Http;

namespace MarkFlixWebAPI.Services
{
    public class TautulliService : ITautulliService
    {
        private readonly HttpClient _httpClient;
        private readonly ITheMovieDBService _theMovieDBService;
        private readonly string _apiKey = "332585e9a336416fba06c72da3a3cb7d";

        public TautulliService(
            HttpClient httpClient, 
            ITheMovieDBService theMovieDBService)
        {
            _httpClient = httpClient;
            _theMovieDBService = theMovieDBService;
        }
        public async Task<IEnumerable<User>?> GetUsers()
        {
            var response = await _httpClient.GetAsync($"?apikey={_apiKey}&cmd=get_users_table");

            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();
            var responseObject = await JsonSerializer.DeserializeAsync<GetUsersResult>(responseStream);

            return responseObject?.response?.data.data.Select(i => new User
            {
                UserId = i.user_id,
                Name = i.friendly_name,
                Plays = i.plays,
                Duration = i.duration,
                LastPlayed = i.last_played,
                Platform = i.platform,
                UserThumb = i.user_thumb,
                MediaType = i.media_type
            });
        }

        public async Task<IEnumerable<HomeStat>?> GetHomeStats()
        {
            var response = await _httpClient.GetAsync($"?apikey={_apiKey}&cmd=get_home_stats&stat_id=top_movies");

            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();
            var responseObject = await JsonSerializer.DeserializeAsync<GetMoviesResult>(responseStream);

            return responseObject?.response?.data.Select(i => new HomeStat
            {
                StatId = i.stat_id,
                StatTitle = i.stat_title,
                
            });


        }

        public async Task<IEnumerable<Movie>?> GetRecentlyAdded()
        {
            var response = await _httpClient.GetAsync($"?apikey={_apiKey}&cmd=get_recently_added&count=200");

            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();
            var responseObject = await JsonSerializer.DeserializeAsync<GetRecentlyAddedResult>(responseStream);

            //var imageString = await TheMovieDBService.GetArtwork(responseObject.response.data.recently_added[0].)

            return responseObject?.response?.data.recently_added.Select(i => new Movie
            {
                Title = i.title,
                ParentTitle = i.parent_title,
                OriginalTitle = i.original_title,
                Guids = i.guids,
                LibraryName = i.library_name,
                MediaType = i.media_type,
                WasWatched = (i.last_viewed_at == "" ? "Never Watched" : i.last_viewed_at)

                //Artwork = String.Format("https://image.tmdb.org/t/p/w500{0}", _theMovieDBService.GetArtwork(int.Parse(i.guids.First().Substring(7,-1)), (i.media_type == "season" || i.media_type == "episode" ? "tv" : "movie")).Result)

            }); ;



            //responseObject?.response?.data.Select(i => new Movie
            //{
            //    for (var row in this.i)
            //{
            //    Title = i.rows[0].title,
            //    Year = i.rows[0].year,
            //    TotalPlays = i.rows[0].total_plays,
            //    Artwork = i.rows[0].art,
            //    MediaType = i.rows[0].media_type

            //}

            //});


        }


        public async Task<IEnumerable<UserStats>?> GetUserPlayerStats(string Id)
        {
            var response = await _httpClient.GetAsync($"?apikey={_apiKey}&cmd=get_user_player_stats&user_id={Id}");

            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();
            var responseObject = await JsonSerializer.DeserializeAsync<GetUserPlayerStatsResults>(responseStream);

            return responseObject?.response?.data.Select(i => new UserStats
            {
                PlayerName = i.player_name,
                Platform = i.platform,
                PlatformName = i.platform,
                totalPlays = i.total_plays,
                totalTime = i.total_time,
                resultId = i.result_id

            });
        }


        public async Task<IEnumerable<Library>?> GetLibraries()
        {
            var response = await _httpClient.GetAsync($"?apikey={_apiKey}&cmd=get_libraries");

            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();
            var responseObject = await JsonSerializer.DeserializeAsync<GetLibrariesResult>(responseStream);

            return responseObject?.response?.data.Select(i => new Library
            {
                SectionId = int.Parse(i.section_id),
                LibraryName = i.section_name,
                LibraryType = i.section_type,
                Count = i.is_active

            });
        }

        public async Task<IEnumerable<User>?> GetLibraryUserStats(int sectionId)
        {
            var response = await _httpClient.GetAsync($"?apikey={_apiKey}&cmd=get_library_user_stats&section_id={sectionId}");

            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();
            var responseObject = await JsonSerializer.DeserializeAsync<GetLibraryUserStatsResult>(responseStream);

            return responseObject?.response?.data.Select(i => new User
            {
                Name = i.friendly_name,
                UserId = i.user_id,
                TotalPlays = i.total_plays,
                Email = i.username,
                UserThumb = i.user_thumb


            });
        }
    }
}
