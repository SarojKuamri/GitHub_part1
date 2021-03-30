using BookMyShow.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BookMyShow.Controllers
{
    public class AccountController : Controller
    {
        private MovieDBContext _dbContext;
        public AccountController(MovieDBContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User model)
        {
            if (ModelState.IsValid)
            {  
             
                    User user = _dbContext.Users
                                       .Where(u => u.UserId == model.UserId && u.Password == model.Password)
                                       .FirstOrDefault();

                    if (user != null)
                    {
                    TempData["UserName"] = user.UserName;
                    TempData["UserId"] = user.UserId;
                    //Session["UserName"] = user.UserName;
                    //    Session["UserId"] = user.UserId;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid User Name or Password");
                        return View(model);
                    }  
            }
            else
            {
                return View(model);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            TempData["UserName"] = string.Empty;
            TempData["UserId"] = string.Empty;
            return RedirectToAction("Index", "Home");
        }
    }
}
