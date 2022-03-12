namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "ReturnDate", c => c.DateTime(nullable: false, storeType: "date"));
            DropColumn("dbo.Rentals", "EndDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rentals", "EndDate", c => c.DateTime(nullable: false, storeType: "date"));
            DropColumn("dbo.Rentals", "ReturnDate");
        }
    }
}
