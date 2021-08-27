namespace MovieDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cardnumbertostring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "CardNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "CardNumber", c => c.Int(nullable: false));
        }
    }
}
