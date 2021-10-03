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
        //===============================
        // GET: All Products + SearchBar(by Productname)
        //===============================
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




        //===========================
        //Get Single Product Details (by ProductId)
        //===========================
        [Route("Products/Details/{Id}")]
        public ActionResult Details(long Id)
        {
            //DbContext 
            ProductsEF_DbEntities db = new ProductsEF_DbEntities();

            //SingleProduct (FirstOrDefault() => returns First matching record else null)
            Product product = db.Products.Where(p => p.ProductId == Id).FirstOrDefault();

            //Return Single (Matching Id) Product Details
            return View(product);
        }





        //========================
        //CREATE/Add new  Product
        //========================
        //1.ADD PRODUCT FORM - GET
        //-------------------------
        [HttpGet]
        [Route("Products/Create")]
        public ActionResult Create()
        {
            //Get Product Form
            return View();
        }


        //2.ADD PRODUCT - POST
        //---------------------
        [HttpPost]
        [Route("Products/Create")]
        public ActionResult Create(Product p)
        {
            //DbContext
            ProductsEF_DbEntities db = new ProductsEF_DbEntities();

            //Add Product to Db + SaveChanges
            db.Products.Add(p);
            db.SaveChanges();

            //After adding product -> show all products
            return RedirectToAction("Index", "Products");
        }





        //======================
        // UPDATE Product (row)
        //======================
        //1.Edit Product Form with Prefetched Product data
        //--------------------
        [HttpGet]
        [Route("Products/Edit/{Id}")]
        public ActionResult Edit(long Id)
        {
            //Current DbContext 
            ProductsEF_DbEntities db = new ProductsEF_DbEntities();

            //Get ProductId(to check if id is received)
            //return Content(Id.ToString());

            //Find Product by Id + return to Edit Form View => Prefetch Product currentData
            Product product = db.Products.Where(p => p.ProductId == Id).FirstOrDefault();

            //ProductForm (Edit View)
            return View(product);
        }

        //2.UPDATE Product - ProductId (from EDIT ProductForm)
        //-----------------------------
        [HttpPost]
        [Route("Products/Edit/{Id}")]
        public ActionResult Edit(long Id,Product p)
        {
            //Current DbContext 
            ProductsEF_DbEntities db = new ProductsEF_DbEntities();

            //Find Product by Id (Compare ProductId from DbContext with received ProductId from EDIT Form)
            Product product = db.Products.Where(prod => prod.ProductId == p.ProductId).FirstOrDefault();

            //Update Row(Product) 
            //ASSIGN Updated values to productFound -> product
            product.ProductName = p.ProductName;
            product.Price = p.Price;
            product.DateOfPurchase = p.DateOfPurchase;
            product.AvailabilityStatus = p.AvailabilityStatus;
            product.CategoryId = p.CategoryId;
            product.BrandId = p.BrandId;
            product.Active = p.Active;

            //Save Changes
            db.SaveChanges();
            return RedirectToAction("Index", "Products");

        }





        //================
        //DELETE Product
        //================
        [HttpGet]
        [Route("Products/Delete/{Id}")]
        public ActionResult Delete(long Id)
        {
            //DbContext
            ProductsEF_DbEntities db = new ProductsEF_DbEntities();

            //Find Product by Id
            Product product = db.Products.Where(p => p.ProductId == Id).FirstOrDefault();

            //return product -> Delete View
            return View(product);
        }

        [HttpPost]
        [Route("Products/Delete/{Id}")]
        public ActionResult Delete(long Id,Product p)
        {
            //DbContext 
            ProductsEF_DbEntities db = new ProductsEF_DbEntities();

            //FInd Product by Id 
            Product product = db.Products.Where(prod => prod.ProductId == Id).FirstOrDefault();

            //Remove from Db + SaveChanges
            db.Products.Remove(product);
            db.SaveChanges();

            //Redirect to ProductsList after Deleting Product
            return RedirectToAction("Index", "Products");
            
        }

    }
}