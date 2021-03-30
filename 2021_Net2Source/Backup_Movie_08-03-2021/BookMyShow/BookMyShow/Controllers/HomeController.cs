using BookMyShow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Controllers
{
    public class HomeController : Controller
    {
        //------start Authorization Filter concept-----

        //public string Index()
        //{
        //    return "index";
        //}

        //[Authorize("Read")]
        //public string Read()
        //{
        //    return "read";
        //}

        //[Authorize("Write")]
        //public string Edit()
        //{
        //    return "edit";
        //}

        //public class AuthorizeAttribute : TypeFilterAttribute
        //{
        //    public AuthorizeAttribute(string permission)
        //        : base(typeof(AuthorizeActionFilter))
        //    {
        //        Arguments = new object[] { permission };
        //    }
        //}

        //public abstract class account
        //{
        //    public abstract void showdata();
        //    public string create()
        //    {
        //        return "create";
        //    }
        //}

        //------ end Authorization Filter concept-----

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
