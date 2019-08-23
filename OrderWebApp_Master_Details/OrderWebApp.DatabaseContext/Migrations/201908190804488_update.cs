namespace OrderWebApp.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FoodName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Email = c.String(),
                        Contact = c.String(),
                        UnitPrice = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        OrderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: false)
                .Index(t => t.OrderID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MemberID = c.Int(nullable: false),
                        MemberTypeID = c.Int(nullable: false),
                        FoodID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Foods", t => t.FoodID, cascadeDelete: false)
                .ForeignKey("dbo.Members", t => t.MemberID, cascadeDelete: false)
                .ForeignKey("dbo.MemberTypes", t => t.MemberTypeID, cascadeDelete: false)
                .Index(t => t.MemberID)
                .Index(t => t.MemberTypeID)
                .Index(t => t.FoodID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "MemberTypeID", "dbo.MemberTypes");
            DropForeignKey("dbo.Orders", "MemberID", "dbo.Members");
            DropForeignKey("dbo.Orders", "FoodID", "dbo.Foods");
            DropIndex("dbo.Orders", new[] { "FoodID" });
            DropIndex("dbo.Orders", new[] { "MemberTypeID" });
            DropIndex("dbo.Orders", new[] { "MemberID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Foods");
        }
    }
}
