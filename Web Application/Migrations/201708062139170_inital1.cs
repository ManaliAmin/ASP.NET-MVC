namespace Assign9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inital1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Artists", "Portrayal", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Artists", "Portrayal", c => c.String(maxLength: 1000));
        }
    }
}
