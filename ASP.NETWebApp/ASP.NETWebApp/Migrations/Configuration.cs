namespace ASP.NETWebApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ASP.NETWebApp.Models.ProductsEF_DbEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ASP.NETWebApp.Models.ProductsEF_DbEntities";
        }

        //=======
        //SEEDER
        //=======
        protected override void Seed(ASP.NETWebApp.Models.ProductsEF_DbEntities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //EXAMPLE:
            /*context.Brands.AddOrUpdate(new Models.Brand() {BrandId=1, BrandName="Sony"});
                 context.Categories.AddOrUpdate(new Models.Category() { CategoryId = 1, CategoryName = "Electronics" });
            */
        }
    }
}
