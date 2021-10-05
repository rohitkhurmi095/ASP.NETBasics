using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//For DbContext
using System.Data.Entity;

namespace ASP.NETWebApp.Models
{
    //So DbContextName = ProductsEf_DbEntities
    public class ProductsEF_DbEntities : DbContext
    {
        //Pass the connectionString -> DbContext Class
        //DbContext => queing db
        public ProductsEF_DbEntities():base("ProductsEF_DbEntities")
        {

        }

        //---------------------------------
        //DbContext = Collection of DbSets
        //----------------------------------
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet <Product> Products { get; set; }
    }


}