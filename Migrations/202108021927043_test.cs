namespace MovieDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Runtime", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Runtime", c => c.Int(nullable: false));
        }
    }
}
