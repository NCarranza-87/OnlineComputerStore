namespace OnlineComputerStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteredProducts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Category", c => c.String(maxLength: 55, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Category");
        }
    }
}
