namespace Map4D.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false),
                        Subject = c.String(nullable: false),
                        Message = c.String(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.GuestModels");
        }
        
        public override void Down()
        {
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
            
            DropTable("dbo.Contacts");
        }
    }
}
