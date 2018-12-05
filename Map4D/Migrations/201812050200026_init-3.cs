namespace Map4D.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GuestModels", "GuestName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GuestModels", "GuestName", c => c.String(nullable: false));
        }
    }
}
