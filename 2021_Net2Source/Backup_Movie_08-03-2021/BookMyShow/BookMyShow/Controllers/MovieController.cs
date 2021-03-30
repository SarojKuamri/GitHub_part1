using BookMyShow.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace BookMyShow.Controllers
{
    public class MovieController : Controller
    {
        private MovieDBContext _dbContext;
        public MovieController(MovieDBContext context)
        {
            _dbContext = context;
        }
        public IActionResult Index()
        {

            var Movielist = _dbContext.MovieModels.ToList();
            return View(Movielist);
        }

        public IActionResult CreateMovie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateMovie(MovieModel myMovie)
        {
            _dbContext.MovieModels.Add(myMovie);
            _dbContext.SaveChanges();
            return View();
        }
        public IActionResult EditMovie(int id)
        {
            var data = _dbContext.MovieModels.Find(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult EditMovie(MovieModel myMovie)
        {
            _dbContext.Entry(myMovie).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbContext.SaveChanges();
            return View();
        }

        public IActionResult DeleteMovie(int id)
        {
            var data = _dbContext.MovieModels.Find(id);
            return View(data);

        }
        [HttpPost]
        public IActionResult DeleteMovie(MovieModel myMovie)
        {
            _dbContext.Remove(myMovie).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _dbContext.SaveChanges();
            return View("Index");
        }
    }
}
