namespace OrderWebApp.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bgt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Qunatity", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Date");
            DropColumn("dbo.Orders", "Qunatity");
        }
    }
}
