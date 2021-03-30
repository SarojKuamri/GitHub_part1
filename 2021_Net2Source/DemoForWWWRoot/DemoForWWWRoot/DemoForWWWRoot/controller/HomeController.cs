using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoForWWWRoot.controller
{
    public class HomeController : Controller
    {
        
        public string Index()
        {
            return "index";
        }

        [Authorize("Read")]
        public string Read()
        {
            return "read";
        }

        [Authorize("Write")]
        public string Edit()
        {
            return "edit";
        }
    }
    public class AuthorizeAttribute : TypeFilterAttribute
    {
        public AuthorizeAttribute(string permission)
            : base(typeof(AuthorizeActionFilter))
        {
            Arguments = new object[] { permission };
        }
    }

    public abstract class account
    {
        public abstract void showdata();
        public string create()
        {
            return "create";
        }
    }

    //public class myaccount : account
    //{
    //    public override void showdata()
    //    {
    //        //
    //    }
    //}
    //public sealed class loan
    //{
    //    public void showdata()
    //    {

    //    }
    //}
    //public class callaccount
    //{
    //    public void calldata()
    //    {
    //        loan loanobj = new loan();
    //        loanobj.showdata();

    //        account obj = new account();
    //        obj.showdata();
    //        obj.create();
    //    }
    //}

    //interface IResult
    //{
    //    void createloan();
    //    void showloan();
    //}
    //class loan : IResult
    //{
    //    public void createloan()
    //    {
    //        //
    //    }

    //    public void showloan()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
