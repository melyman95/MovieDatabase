namespace MovieDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        MovieTitle = c.String(maxLength: 128),
                        ShippingName = c.String(),
                        CardNumber = c.Int(nullable: false),
                        Cvv = c.Int(nullable: false),
                        ExpDate = c.String(),
                        BillingAddress = c.String(),
                        PhoneNumber = c.String(),
                        ShippingAddress = c.String(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Movies", t => t.MovieTitle)
                .Index(t => t.MovieTitle);
            
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
            DropForeignKey("dbo.Orders", "MovieTitle", "dbo.Movies");
            DropIndex("dbo.Orders", new[] { "MovieTitle" });
            DropTable("dbo.Movies");
            DropTable("dbo.Orders");
        }
    }
}
