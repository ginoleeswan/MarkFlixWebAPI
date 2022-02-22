using MarkFlixWebAPI.Models;
using MarkFlixWebAPI.Models.Movies;
using MarkFlixWebAPI.Models.UserStats;
using MarkFlixWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MarkFlixWebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITautulliService _tautulliService;
        private readonly ITheMovieDBService _theMovieDBService;

        public HomeController(
            ILogger<HomeController> logger,
            ITautulliService tautulliService,
            ITheMovieDBService theMovieDBService
            )
        {
            _logger = logger;
            _tautulliService = tautulliService;
            _theMovieDBService = theMovieDBService;    
        }

        public IActionResult Index()
        {
            return View();
        }

        private async Task<IEnumerable<HomeStat>> GetHomeStats()
        {
            try
            {
                var homeStats = await _tautulliService.GetHomeStats();

                return homeStats;
            }
            catch (Exception ex)
            {
                Debug.Write(ex);

                return Enumerable.Empty<HomeStat>();
            }

        }

        private async Task<IEnumerable<UserStats>> GetUserPlayerStats()
        {
            try
            {
                var userStats = await _tautulliService.GetUserPlayerStats("17375975");

                return userStats;
            }
            catch (Exception ex)
            {
                Debug.Write(ex);

                return Enumerable.Empty<UserStats>();
            }

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}