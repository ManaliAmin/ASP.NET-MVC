namespace Assign9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inital : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Albums", "Executive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Albums", "Executive", c => c.String(nullable: false, maxLength: 200));
        }
    }
}
