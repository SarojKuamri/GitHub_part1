using BookMyShow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Controllers
{
    public class LocationController : Controller
    {
        private MovieDbContext _DbContext;
        public LocationController(MovieDbContext context)
        {
            _DbContext = context;
        }
        public IActionResult Index()
        {
            var LocationModel = _DbContext.locationModels.ToList();
            return View(LocationModel);
        }
        public IActionResult CreateLocation()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateLocation( LocationModel locationmodel)
        {
            _DbContext.locationModels.Add(locationmodel);
            _DbContext.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult EditLocation(int LocId)
        {

            return View(_DbContext.locationModels.Find(LocId));
        }

        [HttpPost]
        public IActionResult EditLocation(LocationModel locationmodel)
        {
            _DbContext.Entry(locationmodel).State = EntityState.Modified;
            _DbContext.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult DeleteLocation(int LocId)
        {
            return View(_DbContext.locationModels.Find(LocId));
        }

        [HttpPost]
        public IActionResult DeleteLocation(LocationModel locationmodel)
        {
            _DbContext.Remove(locationmodel).State = EntityState.Deleted;
            _DbContext.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
