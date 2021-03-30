using BookMyShow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Controllers
{
    public class TheaterController : Controller
    {
       private MovieDbContext _Dbcontext;
        public TheaterController(MovieDbContext context)
        {
            _Dbcontext = context;
        }
        public IActionResult Index()
        {
            var TheaterList = _Dbcontext.TheaterModels.ToList();
            return View(TheaterList);
        }

        public IActionResult CreateTheater()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTheater(TheaterModel theater)
        {
            _Dbcontext.TheaterModels.Add(theater);
            _Dbcontext.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult EditTheater(int Id)
        {

            return View(_Dbcontext.TheaterModels.Find(Id));
        }

        [HttpPost]
        public IActionResult EditTheater(TheaterModel theatermodel)
        {
            _Dbcontext.Entry(theatermodel).State = EntityState.Modified;
            _Dbcontext.SaveChanges();
            return RedirectToAction("index");
        }


        public IActionResult DeleteTheater(int Id)
        {
            return View(_Dbcontext.TheaterModels.Find(Id));
        }

        [HttpPost]
        public IActionResult DeleteTheater(TheaterModel theatermodel)
        {
            _Dbcontext.Remove(theatermodel).State = EntityState.Deleted;
            _Dbcontext.SaveChanges();
            return RedirectToAction("index");
        }


    }
}
