namespace Assign9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inital2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Albums", "Depiction", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Albums", "Depiction", c => c.String(maxLength: 200));
        }
    }
}
