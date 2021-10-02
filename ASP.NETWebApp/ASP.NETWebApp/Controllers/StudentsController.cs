using ASP.NETWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NETWebApp.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("Students/Create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("Students/Create")]
        //Custom model Binder 
        public ActionResult Create([ModelBinder(typeof(StudentCustomBinder))]Student s)
        {
            //logic here
            return View();
        }


    }
}