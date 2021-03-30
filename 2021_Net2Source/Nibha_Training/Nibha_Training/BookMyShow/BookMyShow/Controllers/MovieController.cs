using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Models;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Controllers
{
    public class MovieController : Controller
    {
       private  MovieDbContext _DbContext;
       public MovieController(MovieDbContext context)
        {
            _DbContext = context;
        }
        public IActionResult Index()
        {
            var MovieDetails = _DbContext.MovieModels.ToList();
            return View(MovieDetails);
        }
        public IActionResult CreateMovie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateMovie(MovieModel moviemodel)
        {
            _DbContext.MovieModels.Add(moviemodel);
            _DbContext.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult EditMovie(int MovieId)
        {
           return View(_DbContext.MovieModels.Find(MovieId));
            //return View(_DbContext.MovieModels.Where(a => a.MovieId == MovieId).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult EditMovie( MovieModel movie)
        {
            _DbContext.Entry(movie).State = EntityState.Modified;
            _DbContext.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult DeleteMovie(int MovieId)
        {
            return View(_DbContext.MovieModels.Find(MovieId));
        }
        [HttpPost]
        public IActionResult DeleteMovie(MovieModel movie)
        {
            _DbContext.Remove(movie).State = EntityState.Deleted;
            _DbContext.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
