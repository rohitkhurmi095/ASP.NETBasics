using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NETWebApp.Models;

namespace ASP.NETWebApp.Controllers
{
    public class CategoriesController : Controller
    {


        // GET: Categories
        [Route("Categories/Index")]
        public ActionResult Index()
        {
            //DbContext
            ProductsEF_DbEntities db = new ProductsEF_DbEntities();

            //DbContext -> Categories (Table)
            //Retriving all Rows
            //db.ToList()(Linq->Sql)
            List<Category> categories = db.Categories.ToList();

            //return Categories -> View
            return View(categories);
        }
    }
}