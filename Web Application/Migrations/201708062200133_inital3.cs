namespace Assign9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inital3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MediaItems", "ContentType", c => c.String());
            AlterColumn("dbo.MediaItems", "Caption", c => c.String());
            AlterColumn("dbo.Tracks", "AudioContentType", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tracks", "AudioContentType", c => c.String(maxLength: 200));
            AlterColumn("dbo.MediaItems", "Caption", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.MediaItems", "ContentType", c => c.String(maxLength: 200));
        }
    }
}
