namespace HomeAssignment03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        Address1 = c.String(),
                        ZipCode = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        Type_AddressTypeId = c.Int(),
                        Contact_ContactId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.AddressTypes", t => t.Type_AddressTypeId)
                .ForeignKey("dbo.Contacts", t => t.Contact_ContactId, cascadeDelete: true)
                .Index(t => t.Type_AddressTypeId)
                .Index(t => t.Contact_ContactId);
            
            CreateTable(
                "dbo.AddressTypes",
                c => new
                    {
                        AddressTypeId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.AddressTypeId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ContactId);
            
            CreateTable(
                "dbo.PhoneNumbers",
                c => new
                    {
                        PhoneNumberId = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Type_PhoneTypeId = c.Int(),
                        Contact_ContactId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PhoneNumberId)
                .ForeignKey("dbo.PhoneTypes", t => t.Type_PhoneTypeId)
                .ForeignKey("dbo.Contacts", t => t.Contact_ContactId, cascadeDelete: true)
                .Index(t => t.Type_PhoneTypeId)
                .Index(t => t.Contact_ContactId);
            
            CreateTable(
                "dbo.PhoneTypes",
                c => new
                    {
                        PhoneTypeId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.PhoneTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhoneNumbers", "Contact_ContactId", "dbo.Contacts");
            DropForeignKey("dbo.PhoneNumbers", "Type_PhoneTypeId", "dbo.PhoneTypes");
            DropForeignKey("dbo.Addresses", "Contact_ContactId", "dbo.Contacts");
            DropForeignKey("dbo.Addresses", "Type_AddressTypeId", "dbo.AddressTypes");
            DropIndex("dbo.PhoneNumbers", new[] { "Contact_ContactId" });
            DropIndex("dbo.PhoneNumbers", new[] { "Type_PhoneTypeId" });
            DropIndex("dbo.Addresses", new[] { "Contact_ContactId" });
            DropIndex("dbo.Addresses", new[] { "Type_AddressTypeId" });
            DropTable("dbo.PhoneTypes");
            DropTable("dbo.PhoneNumbers");
            DropTable("dbo.Contacts");
            DropTable("dbo.AddressTypes");
            DropTable("dbo.Addresses");
        }
    }
}
