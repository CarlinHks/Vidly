namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieProp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "RealeaseDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "AddDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Stock", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Movies", "Detail", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Detail", c => c.String());
            AlterColumn("dbo.Movies", "Name", c => c.String());
            DropColumn("dbo.Movies", "Stock");
            DropColumn("dbo.Movies", "AddDateTime");
            DropColumn("dbo.Movies", "RealeaseDateTime");
        }
    }
}
