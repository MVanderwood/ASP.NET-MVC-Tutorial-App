namespace MVCTutoialApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        AmountSold = c.Int(nullable: false),
                        Sales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Artist_ArtistID = c.Int(),
                    })
                .PrimaryKey(t => t.AlbumID)
                .ForeignKey("dbo.Artists", t => t.Artist_ArtistID)
                .Index(t => t.Artist_ArtistID);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Bio = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ArtistID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false),
                        Rating = c.Int(nullable: false),
                        AlbumID = c.Int(nullable: false),
                        ReviewerEmail = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Albums", t => t.AlbumID, cascadeDelete: true)
                .Index(t => t.AlbumID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "AlbumID", "dbo.Albums");
            DropForeignKey("dbo.Albums", "Artist_ArtistID", "dbo.Artists");
            DropIndex("dbo.Reviews", new[] { "AlbumID" });
            DropIndex("dbo.Albums", new[] { "Artist_ArtistID" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Artists");
            DropTable("dbo.Albums");
        }
    }
}
