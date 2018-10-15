namespace Transaction.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitalDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Deliver_Id = c.Int(nullable: false),
                        DateTime_Transaction = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Distance = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Deliver_Id })
                .ForeignKey("dbo.Delivers", t => t.Deliver_Id, cascadeDelete: true)
                .ForeignKey("dbo.User_Transactions", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Deliver_Id);
            
            CreateTable(
                "dbo.Delivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Deliver_Name = c.String(nullable: false, maxLength: 50),
                        Deliver_Password = c.String(maxLength: 50),
                        Deliver_Email = c.String(nullable: false, maxLength: 50),
                        Deliver_City = c.String(nullable: false),
                        Deliver_Town = c.String(nullable: false),
                        Telephone_Number = c.String(nullable: false),
                        Deliver_Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User_Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Name = c.String(nullable: false, maxLength: 50),
                        User_Password = c.String(maxLength: 50),
                        User_Email = c.String(nullable: false, maxLength: 50),
                        User_City = c.String(nullable: false, maxLength: 50),
                        User_Town = c.String(nullable: false, maxLength: 50),
                        Type_Commodity = c.String(maxLength: 50),
                        Telephone_Number = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contacts", "User_Id", "dbo.User_Transactions");
            DropForeignKey("dbo.Contacts", "Deliver_Id", "dbo.Delivers");
            DropIndex("dbo.Contacts", new[] { "Deliver_Id" });
            DropIndex("dbo.Contacts", new[] { "User_Id" });
            DropTable("dbo.User_Transactions");
            DropTable("dbo.Delivers");
            DropTable("dbo.Contacts");
        }
    }
}
