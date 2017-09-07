namespace Assign9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "Depiction", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "Depiction");
        }
    }
}
