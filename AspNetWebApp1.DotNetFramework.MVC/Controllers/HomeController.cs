using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AspNetWebApp1.DotNetFramework.MVC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }
    }
}
