namespace OrderWebApp.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 7),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Contact = c.String(nullable: false),
                        MemberTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MemberTypes", t => t.MemberTypeID, cascadeDelete: true)
                .Index(t => t.MemberTypeID);
            
            CreateTable(
                "dbo.MemberTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "MemberTypeID", "dbo.MemberTypes");
            DropIndex("dbo.Members", new[] { "MemberTypeID" });
            DropTable("dbo.MemberTypes");
            DropTable("dbo.Members");
        }
    }
}
