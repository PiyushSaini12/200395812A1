namespace _200395812A1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Developer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VideoGames", "PublisherName_PublisherId", "dbo.Publishers");
            DropForeignKey("dbo.VideoGames", "PublisherWebsite_PublisherId", "dbo.Publishers");
            DropIndex("dbo.VideoGames", new[] { "PublisherName_PublisherId" });
            DropIndex("dbo.VideoGames", new[] { "PublisherWebsite_PublisherId" });
            CreateTable(
                "dbo.Developers",
                c => new
                    {
                        DeveloperId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.DeveloperId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        Subject = c.String(),
                        Review = c.String(),
                        NumberOfStars = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewId);
            
            AddColumn("dbo.Publishers", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Publishers", "Website", c => c.String());
            AddColumn("dbo.VideoGames", "Publisher", c => c.String(nullable: false));
            AlterColumn("dbo.VideoGames", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.VideoGames", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.VideoGames", "Developer", c => c.String(nullable: false));
            AlterColumn("dbo.VideoGames", "Genre", c => c.String(nullable: false));
            DropColumn("dbo.Publishers", "PublisherName");
            DropColumn("dbo.Publishers", "PublisherWebsite");
            DropColumn("dbo.VideoGames", "PublisherName_PublisherId");
            DropColumn("dbo.VideoGames", "PublisherWebsite_PublisherId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VideoGames", "PublisherWebsite_PublisherId", c => c.Int());
            AddColumn("dbo.VideoGames", "PublisherName_PublisherId", c => c.Int());
            AddColumn("dbo.Publishers", "PublisherWebsite", c => c.String());
            AddColumn("dbo.Publishers", "PublisherName", c => c.String());
            AlterColumn("dbo.VideoGames", "Genre", c => c.String());
            AlterColumn("dbo.VideoGames", "Developer", c => c.String());
            AlterColumn("dbo.VideoGames", "Description", c => c.String());
            AlterColumn("dbo.VideoGames", "Name", c => c.String());
            DropColumn("dbo.VideoGames", "Publisher");
            DropColumn("dbo.Publishers", "Website");
            DropColumn("dbo.Publishers", "Name");
            DropTable("dbo.Reviews");
            DropTable("dbo.Genres");
            DropTable("dbo.Developers");
            CreateIndex("dbo.VideoGames", "PublisherWebsite_PublisherId");
            CreateIndex("dbo.VideoGames", "PublisherName_PublisherId");
            AddForeignKey("dbo.VideoGames", "PublisherWebsite_PublisherId", "dbo.Publishers", "PublisherId");
            AddForeignKey("dbo.VideoGames", "PublisherName_PublisherId", "dbo.Publishers", "PublisherId");
        }
    }
}
