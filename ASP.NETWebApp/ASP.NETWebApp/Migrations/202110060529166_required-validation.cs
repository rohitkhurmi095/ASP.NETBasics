namespace ASP.NETWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requiredvalidation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.Products", new[] { "BrandId" });
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.Products", "DateOfPurchase", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "AvailabilityStatus", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "CategoryId", c => c.Long(nullable: false));
            AlterColumn("dbo.Products", "BrandId", c => c.Long(nullable: false));
            AlterColumn("dbo.Products", "Active", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Products", "Photo", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Quantity", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "CategoryId");
            CreateIndex("dbo.Products", "BrandId");
            AddForeignKey("dbo.Products", "BrandId", "dbo.Brands", "BrandId", cascadeDelete: true);
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "BrandId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            AlterColumn("dbo.Products", "Quantity", c => c.Int());
            AlterColumn("dbo.Products", "Photo", c => c.String());
            AlterColumn("dbo.Products", "Active", c => c.Boolean());
            AlterColumn("dbo.Products", "BrandId", c => c.Long());
            AlterColumn("dbo.Products", "CategoryId", c => c.Long());
            AlterColumn("dbo.Products", "AvailabilityStatus", c => c.String());
            AlterColumn("dbo.Products", "DateOfPurchase", c => c.DateTime());
            AlterColumn("dbo.Products", "Price", c => c.Double());
            AlterColumn("dbo.Products", "ProductName", c => c.String());
            CreateIndex("dbo.Products", "BrandId");
            CreateIndex("dbo.Products", "CategoryId");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "CategoryId");
            AddForeignKey("dbo.Products", "BrandId", "dbo.Brands", "BrandId");
        }
    }
}
