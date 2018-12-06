namespace Map4D.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                {
                    ID = c.String(nullable: false, maxLength: 128),
                    Name = c.String(nullable: false, maxLength: 50),
                    Company = c.String(nullable: false),
                    Phone = c.String(nullable: false, maxLength: 13),
                    Email = c.String(nullable: false),
                    RegisterDate = c.DateTime(nullable: false),
                    Description = c.String(),
                    Status = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.GuestModels",
                c => new
                {
                    IdGuest = c.Int(nullable: false, identity: true),
                    GuestName = c.String(nullable: false, maxLength: 255),
                    GuestEmail = c.String(nullable: false),
                    GuestSubject = c.String(nullable: false),
                    Message = c.String(nullable: false),
                    DateUp = c.DateTime(nullable: false),
                    Status = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.IdGuest);
        }
            
           
        public override void Down()
        {
          
            DropTable("dbo.GuestModels");
            DropTable("dbo.Customers");
        }
    }
}
