using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TeamOverCinema.Models;
using Microsoft.EntityFrameworkCore;
using TeamOverCinema.Data;
using Microsoft.AspNetCore.Authorization;

namespace TeamOverCinema.Controllers
{
        
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult AdminSeatSelection()
        {
            return View();
        }
        public IActionResult Movies()
        {
            return View();
        }
        public IActionResult FoodandDrink()
        {
            return View();
        }
        public IActionResult Premium()
        {
            return View();
        }
        [Authorize]
        public IActionResult Profile()
        {
            return View();
        }
        [Authorize]
        public IActionResult AdminBookings()
        {
            return View();
        }
        public IActionResult PrivateCinemaB()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Gifts()
        {
            return View();
        }
        public IActionResult Payment()
        {
            return View();
        }
        public IActionResult PaymentGifts()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        // GET: Events
        public async Task<IActionResult> Promotions()
        {
            return _context.Events != null ?
                        View(await _context.Events.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Events'  is null.");
        }

        // GET: Events/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Events == null)
            {
                return NotFound();
            }

            var events = await _context.Events
                .FirstOrDefaultAsync(m => m.ID == id);
            if (events == null)
            {
                return NotFound();
            }

            return View(events);
        }
        // GET: Movies
        public async Task<IActionResult> index()
        {
            return _context.Movies != null ?
                        View(await _context.Movies.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Movies'  is null.");
        }


        // GET: Movies/Details/5
        public async Task<IActionResult> MDetails(int? id)
        {
            if (id == null || _context.Movies == null)
            {
                return NotFound();
            }

            var movies = await _context.Movies
                .FirstOrDefaultAsync(m => m.ID == id);
            if (movies == null)
            {
                return NotFound();
            }

            return View(movies);
        }
    }
}
