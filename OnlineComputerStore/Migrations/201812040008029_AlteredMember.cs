namespace OnlineComputerStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteredMember : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Members", "Password");
            DropColumn("dbo.Members", "CreditCard");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "CreditCard", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.Members", "Password", c => c.String(maxLength: 200, unicode: false));
        }
    }
}
