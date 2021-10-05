namespace ASP.NETWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedqty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Quantity", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Quantity");
        }
    }
}
