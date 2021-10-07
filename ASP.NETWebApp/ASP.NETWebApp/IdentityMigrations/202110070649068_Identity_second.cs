namespace ASP.NETWebApp.IdentityMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Identity_second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Country");
        }
    }
}
