using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookMyShow.Models;

namespace BookMyShow.Controllers
{
    public class RatingModels1Controller : Controller
    {
        private readonly MovieDbContext _context;

        public RatingModels1Controller(MovieDbContext context)
        {
            _context = context;
        }

        // GET: RatingModels1
        public async Task<IActionResult> Index()
        {
            var movieDbContext = _context.RatingModels.Include(r => r.MovieModel);
            return View(await movieDbContext.ToListAsync());
        }

        // GET: RatingModels1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ratingModel = await _context.RatingModels
                .Include(r => r.MovieModel)
                .FirstOrDefaultAsync(m => m.RatingId == id);
            if (ratingModel == null)
            {
                return NotFound();
            }

            return View(ratingModel);
        }

        // GET: RatingModels1/Create
        public IActionResult Create()
        {
            ViewData["MovieId"] = new SelectList(_context.MovieModels, "MovieId", "MovieName");
            return View();
        }

        // POST: RatingModels1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RatingId,MovieRatings,MovieId")] RatingModel ratingModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ratingModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MovieId"] = new SelectList(_context.MovieModels, "MovieId", "MovieName", ratingModel.MovieId);
            return View(ratingModel);
        }

        // GET: RatingModels1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ratingModel = await _context.RatingModels.FindAsync(id);
            if (ratingModel == null)
            {
                return NotFound();
            }
            ViewData["MovieId"] = new SelectList(_context.MovieModels, "MovieId", "MovieName", ratingModel.MovieId);
            return View(ratingModel);
        }

        // POST: RatingModels1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RatingId,MovieRatings,MovieId")] RatingModel ratingModel)
        {
            if (id != ratingModel.RatingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ratingModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RatingModelExists(ratingModel.RatingId))
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
            ViewData["MovieId"] = new SelectList(_context.MovieModels, "MovieId", "MovieName", ratingModel.MovieId);
            return View(ratingModel);
        }

        // GET: RatingModels1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ratingModel = await _context.RatingModels
                .Include(r => r.MovieModel)
                .FirstOrDefaultAsync(m => m.RatingId == id);
            if (ratingModel == null)
            {
                return NotFound();
            }

            return View(ratingModel);
        }

        // POST: RatingModels1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ratingModel = await _context.RatingModels.FindAsync(id);
            _context.RatingModels.Remove(ratingModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RatingModelExists(int id)
        {
            return _context.RatingModels.Any(e => e.RatingId == id);
        }
    }
}
