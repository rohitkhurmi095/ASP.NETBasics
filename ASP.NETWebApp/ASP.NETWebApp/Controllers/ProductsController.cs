using ASP.NETWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NETWebApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: All Products + SearchBar(by Productname)
        //=============================
        [Route("Products/Index")]
        public ActionResult Index(string search = "")
        {
            //DbContext
            ProductsEF_DbEntities db = new ProductsEF_DbEntities();
            //Products DataSet -> Products List
            //----------------
            //List<Product> products = db.Products.ToList();

            //CONDITIONAL DATA
            //-----------------
            //List<Product> selectedProducts = db.Products.Where(p => p.CategoryId == 1 && p.Price >= 50000).ToList();

            //SEACH TERM = FormInput
            ViewBag.Search = search;

            //SEARCH PRODUCT With matching Name from ProductList
            //Product List 
            List<Product> products = db.Products.Where(p => p.ProductName.Contains(search)).ToList();

            //return products -> View
            return View(products); ;
        }


        //Get Single Product(by ProductId)
        //===================
        [Route("Products/Details/{Id}")]
        public ActionResult Details(int Id)
        {
            //DbContext 
            ProductsEF_DbEntities db = new ProductsEF_DbEntities();

            //SingleProduct (FirstOrDefault() => returns First matching record else null)
            Product product = db.Products.Where(p => p.ProductId == Id).FirstOrDefault();

            //Return Single (Matching Id) Product Details
            return View(product);
        }
    }
}