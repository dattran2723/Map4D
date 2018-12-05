namespace Map4D.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerModel : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CustomerModels", newName: "Customers");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Customers", newName: "CustomerModels");
        }
    }
}
