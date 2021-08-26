namespace MovieDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Title = c.String(nullable: false, maxLength: 128),
                        releaseYear = c.Int(nullable: false),
                        Rating = c.String(),
                        Genre = c.String(),
                        Runtime = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Title);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
