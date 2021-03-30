using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;



namespace BookMyShow.Filter
{
    public class AuthorizeFilterController : Controller
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
