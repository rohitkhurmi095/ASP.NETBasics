using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NETWebApp.Controllers
{
    public class HomeController : Controller
    {
        //Home
        //=====
        [Route("Home/Index")]
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        //About
        //======
        [Route("Home/About")]
        public ActionResult About()
        {
            return View();
        }

        //Contact
        //=========
        [Route("Home/Contact")]
        public ActionResult Contact()
        {
            return View();
        }

        //PROFILE
        //=========
        [Route("UserProfile")]
        public ActionResult UserProfile()
        {
            return View();
        }
    }
}