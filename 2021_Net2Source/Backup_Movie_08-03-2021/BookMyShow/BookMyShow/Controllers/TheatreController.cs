using BookMyShow.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Controllers
{
    public class TheatreController : Controller
    {

        private MovieDBContext _dbContext;
        public TheatreController(MovieDBContext context)
        {
            _dbContext = context;
        }
        public IActionResult Index()
        {
            var Theatrelist = _dbContext.TheatreModels.ToList();
            return View(Theatrelist);
        }

        public IActionResult CreateTheatre()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTheatre(TheatreModel myTheatre)
        {
            _dbContext.TheatreModels.Add(myTheatre);
            _dbContext.SaveChanges();
            return View();
        }

        public IActionResult EditTheatre(int id)
        {
            var data = _dbContext.TheatreModels.Find(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult EditTheatre(TheatreModel myTheatre)
        {
            _dbContext.Entry(myTheatre).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbContext.SaveChanges();
            return View();
        }

        public IActionResult DeleteTheatre(int id)
        {
            var data = _dbContext.TheatreModels.Find(id);
            return View(data);

        }
        [HttpPost]
        public IActionResult DeleteTheatre(TheatreModel myTheatre)
        {
            _dbContext.Remove(myTheatre).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _dbContext.SaveChanges();
            return View("Index");
        }

    }
}
