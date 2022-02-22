using MarkFlixWebAPI.Models;
using MarkFlixWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MarkFlixWebAPI.Controllers
{
    public class UsersController : Controller
    {
        private readonly IOverseerrService _overseerrService;
        private readonly ITheMovieDBService _theMovieDBService;

        public UsersController(
            IOverseerrService overseerrService,
            ITheMovieDBService theMovieDBService)
        {
            _overseerrService = overseerrService;
            _theMovieDBService = theMovieDBService;
        }
        public async Task<IActionResult> Index()
        {
            var users = await GetUsers();
            return View(users);
        }

        public async Task<IActionResult> Requests(int? userId)
        {
           
            var requests = await GetRequests(userId);
            return View(requests);
        }

        //GET
        private async Task<IEnumerable<User>> GetUsers()
        {
            try
            {
                //var users = await _tautulliService.GetUsers();
                var users = await _overseerrService.GetUsers();

                return users;
            }
            catch (Exception ex)
            {
                Debug.Write(ex);

                return Enumerable.Empty<User>();
            }

        }

        //GET
        public async Task<IEnumerable<Request>> GetRequests(int? userId)
        {
            try
            {
                var requests = await _overseerrService.GetRequests(userId);
              
                return requests;
            }
            catch (Exception ex)
            {
                Debug.Write(ex);

                return Enumerable.Empty<Request>();
            }
        }
    }
}
