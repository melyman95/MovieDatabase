namespace MovieDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fkremoved : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "MovieTitle", "dbo.Movies");
            DropIndex("dbo.Orders", new[] { "MovieTitle" });
            AlterColumn("dbo.Orders", "MovieTitle", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "MovieTitle", c => c.String(maxLength: 128));
            CreateIndex("dbo.Orders", "MovieTitle");
            AddForeignKey("dbo.Orders", "MovieTitle", "dbo.Movies", "Title");
        }
    }
}
