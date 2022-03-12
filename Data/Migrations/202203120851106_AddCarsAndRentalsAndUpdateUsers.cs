namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarsAndRentalsAndUpdateUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mark = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        Year = c.Int(nullable: false),
                        Fuel = c.String(nullable: false),
                        Transmition = c.String(nullable: false),
                        PricePerDay = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        CarId = c.Int(nullable: false),
                        HireDate = c.DateTime(nullable: false, storeType: "date"),
                        EndDate = c.DateTime(nullable: false, storeType: "date"),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.CarId);
            
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "MiddleName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "PhoneNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "UserId", "dbo.Users");
            DropForeignKey("dbo.Rentals", "CarId", "dbo.Cars");
            DropIndex("dbo.Rentals", new[] { "CarId" });
            DropIndex("dbo.Rentals", new[] { "UserId" });
            AlterColumn("dbo.Users", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "LastName", c => c.String());
            AlterColumn("dbo.Users", "MiddleName", c => c.String());
            AlterColumn("dbo.Users", "FirstName", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Username", c => c.String());
            DropTable("dbo.Rentals");
            DropTable("dbo.Cars");
        }
    }
}
