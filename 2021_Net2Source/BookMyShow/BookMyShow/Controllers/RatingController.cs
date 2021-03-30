using BookMyShow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Controllers
{
    public class RatingController : Controller
    {
        private MovieDBContext _dbContext;
        public RatingController(MovieDBContext context)
        {
            _dbContext = context;
        }
        public IActionResult Index()
        {
            var Movielist = _dbContext.RatingModels.Include(obj => obj.MovieModel);
            return View(Movielist.ToList());
        }
        public IActionResult CreateRating()
        {
            ViewData["MovieID"] = new SelectList(_dbContext.MovieModels, "MovieID", "MovieName");
            return View();
        }
        [HttpPost]
        public IActionResult CreateRating(RatingModel ratingmodel)
        {

            _dbContext.RatingModels.Add(ratingmodel);
            _dbContext.SaveChanges();
            ViewData["MovieID"] = new SelectList(_dbContext.MovieModels, "MovieID", "MovieName");
            return View();
        }
        public IActionResult EditRating(int id)
        {
            ViewData["MovieID"] = new SelectList(_dbContext.MovieModels, "MovieID", "MovieName");
            return View(_dbContext.RatingModels.Find(id));

        }
        [HttpPost]
        public IActionResult EditRating(RatingModel ratingmodel)
        {

            _dbContext.Entry(ratingmodel).State = EntityState.Modified;
            //ViewData["MovieId"] = new SelectList(_Dbcontext.MovieModels, "MovieId", "MovieName");
            _dbContext.SaveChanges();

            return View();
        }
        public IActionResult DeleteRating(int id)
        {
            ViewData["MovieId"] = new SelectList(_dbContext.MovieModels, "MovieId", "MovieName");
            return View(_dbContext.RatingModels.Find(id));

        }
        [HttpPost]
        public IActionResult DeleteRating(RatingModel ratingmodel)
        {

            _dbContext.Remove(ratingmodel).State = EntityState.Deleted;
            //ViewData["MovieId"] = new SelectList(_Dbcontext.MovieModels, "MovieId", "MovieName");
            _dbContext.SaveChanges();

            return RedirectToAction("index");
        }

    }
}
