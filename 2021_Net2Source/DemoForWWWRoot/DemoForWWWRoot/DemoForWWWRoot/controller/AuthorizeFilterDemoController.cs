using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoForWWWRoot.controller
{
    public class AuthorizeFilterDemoController : Controller
    {
        [HttpsOnly]
        public string Index()
        {
            return "index page";
        }
    }
    public class HttpsOnly : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            context.Result = context.Result;
        }
    }
}
