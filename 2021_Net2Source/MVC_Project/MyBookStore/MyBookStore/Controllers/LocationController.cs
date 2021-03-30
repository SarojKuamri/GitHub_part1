using Microsoft.AspNetCore.Mvc;
using MyBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyBookStore.Controllers
{
    public class LocationController : Controller
    {
        private MovieDBContext _dbContext;
        public LocationController(MovieDBContext context)
        {
            _dbContext = context;
        }
        public IActionResult Index()
        {

            var locationlist = _dbContext.locationModels.ToList();
            return View(locationlist);
        }
        public IActionResult CreateLocation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateLocation(LocationModel mylocation)
        {
            _dbContext.locationModels.Add(mylocation);
            _dbContext.SaveChanges();
            return View();
        }
        public IActionResult EditLocation(int id)
        {
            var data = _dbContext.locationModels.Find(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult EditLocation(LocationModel mylocation)
        {
            _dbContext.Entry(mylocation).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbContext.SaveChanges();
            return View();
        }
       
        public IActionResult DeleteLocation(int id)
        {
            var data = _dbContext.locationModels.Find(id);
            return View(data);

        }
        [HttpPost]
        public IActionResult DeleteLocation(LocationModel mylocation)
        {
            _dbContext.Remove(mylocation).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _dbContext.SaveChanges();
            return View("Index");
        }
    }
}
