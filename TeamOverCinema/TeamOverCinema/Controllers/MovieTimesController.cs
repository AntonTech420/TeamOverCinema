using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TeamOverCinema.Data;
using TeamOverCinema.Models;

namespace TeamOverCinema.Controllers
{
    public class MovieTimesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MovieTimesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MovieTimes
        public async Task<IActionResult> Index()
        {
              return _context.MovieTimes != null ? 
                          View(await _context.MovieTimes.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.MovieTimes'  is null.");
        }

        // GET: MovieTimes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MovieTimes == null)
            {
                return NotFound();
            }

            var movieTimes = await _context.MovieTimes
                .FirstOrDefaultAsync(m => m.MovieId == id);
            if (movieTimes == null)
            {
                return NotFound();
            }

            return View(movieTimes);
        }

        // GET: MovieTimes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MovieTimes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovieId,MovieName,MovieDate")] MovieTimes movieTimes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movieTimes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movieTimes);
        }

        // GET: MovieTimes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MovieTimes == null)
            {
                return NotFound();
            }

            var movieTimes = await _context.MovieTimes.FindAsync(id);
            if (movieTimes == null)
            {
                return NotFound();
            }
            return View(movieTimes);
        }

        // POST: MovieTimes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovieId,MovieName,MovieDate")] MovieTimes movieTimes)
        {
            if (id != movieTimes.MovieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movieTimes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieTimesExists(movieTimes.MovieId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movieTimes);
        }

        // GET: MovieTimes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MovieTimes == null)
            {
                return NotFound();
            }

            var movieTimes = await _context.MovieTimes
                .FirstOrDefaultAsync(m => m.MovieId == id);
            if (movieTimes == null)
            {
                return NotFound();
            }

            return View(movieTimes);
        }

        // POST: MovieTimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MovieTimes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.MovieTimes'  is null.");
            }
            var movieTimes = await _context.MovieTimes.FindAsync(id);
            if (movieTimes != null)
            {
                _context.MovieTimes.Remove(movieTimes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieTimesExists(int id)
        {
          return (_context.MovieTimes?.Any(e => e.MovieId == id)).GetValueOrDefault();
        }
    }
}
