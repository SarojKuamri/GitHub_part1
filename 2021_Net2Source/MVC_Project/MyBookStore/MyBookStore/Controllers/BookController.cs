using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBookStore.Models;
namespace MyBookStore.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            BookModel obj = new BookModel()
            {
                BookID = 1,
                BookName = "fhgfag",
                Price = 3656,
                writer = "dhgsdh",
                Description = "ghfdhjgsh"

            };
            return View(obj);//means we are returning view page
        
    }
        public string showmsg()
        {
            return "welcome";
        }
    }
}
