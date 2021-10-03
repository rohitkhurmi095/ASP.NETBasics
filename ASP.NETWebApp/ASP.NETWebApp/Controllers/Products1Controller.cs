using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NETWebApp.Models;

namespace ASP.NETWebApp.Controllers
{
    public class Products1Controller : Controller
    {
        //Proudcts List
        //==============
        List<Product1> pList = new List<Product1>()
        {
            new Product1{ProductId=101,ProductName="AC",ProductPrice=45000},
            new Product1{ProductId=102,ProductName="Mobile",ProductPrice=38000},
            new Product1{ProductId=103,ProductName="Bike",ProductPrice=94000},
        };


        // GET: Products
        //================
        [HttpGet]
        [Route("Products1/Index")]
        public ActionResult Index()
        {
            //Total Products
            ViewBag.Total = pList.Count;

            //return ProductsList -> View
            return View(pList);
        }


        //Get Product by Id
        //==================
        [HttpGet]
        [Route("Products1/Details/{id}")]
        public ActionResult Details(int Id)
        {
            //Let ProductFOund = null
            Product1 PFound = null;

            //Search For Product in ProductList
            foreach(Product1 p in pList)
            {
                //If product if found => assign to PFound
                if(p.ProductId == Id)
                {
                    PFound = p;
                }
            }

            //return Product -> View
            return View(PFound);
        }
        

        //CREATE Product
        //===============
        //1.Product Form
     
        [Route("Products1/Create")]
        public ActionResult Create()
        {
            return View();
        }

        //2.Post Product
        [HttpPost]
        [Route("Products1/Create")]
        public ActionResult Create([Bind(Include = "ProductId,ProductName,ProductPrice")] Product1 p)
        {
            //Implement Post Logic here

            return View();
        }
    }
}