using MarkFlixWebAPI.Models.Movies;
using MarkFlixWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MarkFlixWebAPI.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ITautulliService _tautulliService;

        public MoviesController(ITautulliService tautulliService)
        {
            _tautulliService = tautulliService;
        }
        public async Task<IActionResult> Index()
        {
            var recentlyAdded = await GetRecentlyAdded();

            return View(recentlyAdded);
        }

        private async Task<IEnumerable<Movie>> GetRecentlyAdded()
        {
            try
            {
                var recentlyAdded = await _tautulliService.GetRecentlyAdded();

                return recentlyAdded;
            }
            catch (Exception ex)
            {
                Debug.Write(ex);

                return Enumerable.Empty<Movie>();
            }

        }
    }
}
