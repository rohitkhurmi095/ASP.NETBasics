using ASP.NETWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NETWebApp.Controllers
{
    public class BrandsController : Controller
    {
        // GET: Brands
        [Route("Brands/Index")]
        public ActionResult Index()
        {
            //DbContext
            ProductsEF_DbEntities db = new ProductsEF_DbEntities();
            //DbContext -> DataSet(Brands) -> ToList()
            List<Brand> brands = db.Brands.ToList();

            //return Brands -> View
            return View(brands);
        }
    }
}