using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyBookStore.Controllers
{
    public class BookController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Select()
        {
            return View();
        }
        public IActionResult Insert()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public string showmsg()
        {
            return "Welcome";
        }

    }
}
