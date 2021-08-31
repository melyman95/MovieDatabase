namespace MovieDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
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
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Title);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        MovieTitle = c.String(),
                        ShippingName = c.String(),
                        CardNumber = c.String(),
                        Cvv = c.Int(nullable: false),
                        ExpDate = c.String(),
                        BillingAddress = c.String(),
                        PhoneNumber = c.String(),
                        ShippingAddress = c.String(),
                        IsFullFilled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
            DropTable("dbo.Movies");
        }
    }
}
