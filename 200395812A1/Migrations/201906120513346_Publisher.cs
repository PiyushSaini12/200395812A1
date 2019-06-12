namespace _200395812A1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Publisher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        PublisherId = c.Int(nullable: false, identity: true),
                        PublisherName = c.String(),
                        PublisherWebsite = c.String(),
                    })
                .PrimaryKey(t => t.PublisherId);
            
            AddColumn("dbo.VideoGames", "PublisherName_PublisherId", c => c.Int());
            AddColumn("dbo.VideoGames", "PublisherWebsite_PublisherId", c => c.Int());
            CreateIndex("dbo.VideoGames", "PublisherName_PublisherId");
            CreateIndex("dbo.VideoGames", "PublisherWebsite_PublisherId");
            AddForeignKey("dbo.VideoGames", "PublisherName_PublisherId", "dbo.Publishers", "PublisherId");
            AddForeignKey("dbo.VideoGames", "PublisherWebsite_PublisherId", "dbo.Publishers", "PublisherId");
            DropColumn("dbo.VideoGames", "Publisher");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VideoGames", "Publisher", c => c.String());
            DropForeignKey("dbo.VideoGames", "PublisherWebsite_PublisherId", "dbo.Publishers");
            DropForeignKey("dbo.VideoGames", "PublisherName_PublisherId", "dbo.Publishers");
            DropIndex("dbo.VideoGames", new[] { "PublisherWebsite_PublisherId" });
            DropIndex("dbo.VideoGames", new[] { "PublisherName_PublisherId" });
            DropColumn("dbo.VideoGames", "PublisherWebsite_PublisherId");
            DropColumn("dbo.VideoGames", "PublisherName_PublisherId");
            DropTable("dbo.Publishers");
        }
    }
}
