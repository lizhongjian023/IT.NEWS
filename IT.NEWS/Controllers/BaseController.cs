using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT.NEWS.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Session["userInfo"]==null)
            {
                //  没有登录时，都去登录页
               // filterContext.HttpContext.Response.Redirect("/Login/Index");
            }
        }
    }
}