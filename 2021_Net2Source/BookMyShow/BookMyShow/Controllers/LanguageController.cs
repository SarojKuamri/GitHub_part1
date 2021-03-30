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
    public class LanguageController : Controller
    {
        private readonly MovieDBContext _context;

        public LanguageController(MovieDBContext context)
        {
            _context = context;
        }

        // GET: Language
        public async Task<IActionResult> Index()
        {
            var movieDBContext = _context.Languages.Include(l => l.MovieModel);
            return View(await movieDBContext.ToListAsync());
        }

        // GET: Language/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var languageModel = await _context.Languages
                .Include(l => l.MovieModel)
                .FirstOrDefaultAsync(m => m.LangId == id);
            if (languageModel == null)
            {
                return NotFound();
            }

            return View(languageModel);
        }

        // GET: Language/Create
        public IActionResult Create()
        {
            ViewData["MovieId"] = new SelectList(_context.MovieModels, "MovieID", "MovieDescription");
            return View();
        }

        // POST: Language/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LangId,Language,MovieId")] LanguageModel languageModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(languageModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MovieId"] = new SelectList(_context.MovieModels, "MovieID", "MovieDescription", languageModel.MovieId);
            return View(languageModel);
        }

        // GET: Language/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var languageModel = await _context.Languages.FindAsync(id);
            if (languageModel == null)
            {
                return NotFound();
            }
            ViewData["MovieId"] = new SelectList(_context.MovieModels, "MovieID", "MovieDescription", languageModel.MovieId);
            return View(languageModel);
        }

        // POST: Language/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LangId,Language,MovieId")] LanguageModel languageModel)
        {
            if (id != languageModel.LangId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(languageModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LanguageModelExists(languageModel.LangId))
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
            ViewData["MovieId"] = new SelectList(_context.MovieModels, "MovieID", "MovieDescription", languageModel.MovieId);
            return View(languageModel);
        }

        // GET: Language/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var languageModel = await _context.Languages
                .Include(l => l.MovieModel)
                .FirstOrDefaultAsync(m => m.LangId == id);
            if (languageModel == null)
            {
                return NotFound();
            }

            return View(languageModel);
        }

        // POST: Language/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var languageModel = await _context.Languages.FindAsync(id);
            _context.Languages.Remove(languageModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LanguageModelExists(int id)
        {
            return _context.Languages.Any(e => e.LangId == id);
        }
    }
}
