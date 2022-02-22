using MarkFlixWebAPI.Models;
using MarkFlixWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MarkFlixWebAPI.Controllers
{
    public class LibrariesController : Controller
    {
        private readonly ITautulliService _tautulliService;

        public LibrariesController(ITautulliService tautulliService)
        {
            _tautulliService = tautulliService;
        }
        public async Task<IActionResult> Index()
        {
            var libraries = await GetLibraries();

            return View(libraries);
        }

        public async Task<IActionResult> Users(int sectionId)
        {
            var users = await GetLibraryUserStats(sectionId);

            return View(users);
        }


        private async Task<IEnumerable<Library>> GetLibraries()
        {
            try
            {
                var libraries = await _tautulliService.GetLibraries();

                return libraries;
            }
            catch (Exception ex)
            {
                Debug.Write(ex);

                return Enumerable.Empty<Library>();
            }

        }

        private async Task<IEnumerable<User>> GetLibraryUserStats(int sectionId)
        {
            try
            {
                var users = await _tautulliService.GetLibraryUserStats(sectionId);
                return users;
            }
            catch (Exception ex)
            {
                Debug.Write(ex);

                return Enumerable.Empty<User>();
            }

        }
    }
}
