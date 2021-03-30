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
    public class RegisterController : Controller
    {
        private readonly MovieDBContext _context;

        public RegisterController(MovieDBContext context)
        {
            _context = context;
        }

        // GET: Register
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegisterModels.ToListAsync());
        }

        // GET: Register/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registerModel = await _context.RegisterModels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registerModel == null)
            {
                return NotFound();
            }

            return View(registerModel);
        }

        // GET: Register/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Register/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailId,pwd,retypwd")] RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registerModel);
        }

        // GET: Register/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registerModel = await _context.RegisterModels.FindAsync(id);
            if (registerModel == null)
            {
                return NotFound();
            }
            return View(registerModel);
        }

        // POST: Register/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,EmailId,pwd,retypwd")] RegisterModel registerModel)
        {
            if (id != registerModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registerModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegisterModelExists(registerModel.Id))
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
            return View(registerModel);
        }

        // GET: Register/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registerModel = await _context.RegisterModels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registerModel == null)
            {
                return NotFound();
            }

            return View(registerModel);
        }

        // POST: Register/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registerModel = await _context.RegisterModels.FindAsync(id);
            _context.RegisterModels.Remove(registerModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegisterModelExists(int id)
        {
            return _context.RegisterModels.Any(e => e.Id == id);
        }
    }
}
