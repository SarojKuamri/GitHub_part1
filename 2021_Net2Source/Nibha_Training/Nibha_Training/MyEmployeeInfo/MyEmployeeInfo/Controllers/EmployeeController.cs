using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyEmployeeInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEmployeeInfo.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeContext _DbContext;

        public EmployeeController(EmployeeContext context)
        {
            _DbContext = context;
        }

        public IActionResult Index()
        {
            var EmployeeList = _DbContext.EmployeeModels.ToList();
            return View(EmployeeList);
        }

        public IActionResult CreateEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEmployee(EmployeeModel EmpModel)
        {
            _DbContext.EmployeeModels.Add(EmpModel);
            _DbContext.SaveChanges();
            return View();
        }








        public IActionResult EditEmployee(int id)
        {
            return View(_DbContext.EmployeeModels.Find(id));
        }
        [HttpPost]
        public IActionResult EditEmployee(EmployeeModel EmpModel)
        {
            _DbContext.Entry(EmpModel).State = EntityState.Modified;
            _DbContext.SaveChanges();
            return View();
        }
        public IActionResult DeleteEmployee(int id)
        {
            return View(_DbContext.EmployeeModels.Find(id));
        }
        [HttpPost]
        public IActionResult DeleteEmployee(EmployeeModel EmpModel)
        {
            _DbContext.Remove(EmpModel).State = EntityState.Deleted;
            _DbContext.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
