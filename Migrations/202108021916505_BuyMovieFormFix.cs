namespace MovieDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BuyMovieFormFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Runtime", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Runtime", c => c.Int());
        }
    }
}
