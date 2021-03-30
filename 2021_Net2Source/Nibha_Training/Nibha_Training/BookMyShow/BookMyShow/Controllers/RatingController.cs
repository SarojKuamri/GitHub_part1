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
        private MovieDbContext _Dbcontext;
        public RatingController(MovieDbContext context)
        {
            _Dbcontext = context;
        }
        public async Task<IActionResult> Index()
        {
            var MovieRatingList = _Dbcontext.RatingModels.Include(obj => obj.MovieModel);
            return  View(MovieRatingList.ToListAsync());
        }
        public IActionResult CreateRating()
        {
            ViewData["MovieID"] = new SelectList(_Dbcontext.MovieModels, "MovieID", "MovieName");
            return View();
        }
        [HttpPost]
        public IActionResult CreateRating(RatingModel ratingmodel)
        {

            _Dbcontext.RatingModels .Add(ratingmodel);
            _Dbcontext.SaveChanges();
            ViewData["MovieID"] = new SelectList(_Dbcontext.MovieModels, "MovieID", "MovieName");
            return View();
        }
        public IActionResult EditRating(int id)
        {
            ViewData["MovieID"] = new SelectList(_Dbcontext.MovieModels, "MovieID", "MovieName");
            return View(_Dbcontext.RatingModels.Find(id));
           
        }
        [HttpPost]
        public IActionResult EditRating(RatingModel ratingmodel)
        {

            _Dbcontext.Entry(ratingmodel).State = EntityState.Modified;
            //ViewData["MovieId"] = new SelectList(_Dbcontext.MovieModels, "MovieId", "MovieName");
            _Dbcontext.SaveChanges();
           
            return View();
        }
        public IActionResult DeleteRating(int id)
        {
            ViewData["MovieId"] = new SelectList(_Dbcontext.MovieModels, "MovieId", "MovieName");
            return View(_Dbcontext.RatingModels.Find(id));

        }
        [HttpPost]
        public IActionResult DeleteRating(RatingModel ratingmodel)
        {

            _Dbcontext.Remove(ratingmodel).State = EntityState.Deleted;
            //ViewData["MovieId"] = new SelectList(_Dbcontext.MovieModels, "MovieId", "MovieName");
            _Dbcontext.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
