namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Birthdate = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
