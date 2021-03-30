using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoForWWWRoot.controller
{
    public class ResultFilterDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [ChangeView]
        public ViewResult Message()
        {
            return View();
        }
    }
    public class ChangeView : Attribute, IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.Result = new ViewResult
            {
                ViewName = "List"
            };
        }
        public void OnResultExecuted(ResultExecutedContext context)
        {
        }
    }
}
