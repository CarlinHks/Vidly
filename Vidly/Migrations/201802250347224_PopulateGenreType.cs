namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GenreTypes(Name) VALUES ('Comedy')");
            Sql("INSERT INTO GenreTypes(Name) VALUES ('Action')");
            Sql("INSERT INTO GenreTypes(Name) VALUES ('Family')");
            Sql("INSERT INTO GenreTypes(Name) VALUES ('Romance')");
            Sql("INSERT INTO GenreTypes(Name) VALUES ('R-Rated')");
        }
        
        public override void Down()
        {
        }
    }
}
