using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoForWWWRoot.controller
{
    public class ExceptionFilterDemoController : Controller
    {
        [CatchError]
        public IActionResult Index(int? id)
        {
            if (id == null)
                throw new Exception("Error Id cannot be null");
            else
                return View((object)$"The value is {id}");
        }
    }
    public class CatchError : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            context.Result = new ViewResult()
            {
                ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
                {
                    Model = context.Exception.Message
                }
            };
        }
    }
}
