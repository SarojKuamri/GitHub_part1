using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookStore.Controllers
{
    public class TheaterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
