namespace _200395812A1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Publisher2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "Name", c => c.Int(nullable: false));
        }
    }
}
