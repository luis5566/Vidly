namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name,Genre,ReleaseDate,AddedDate,Stock) VALUES('Hangover','Comedy','19961005',GETDATE(),10)");
            Sql("INSERT INTO Movies (Name,Genre,ReleaseDate,AddedDate,Stock) VALUES('Die Hard','Action','19980901',GETDATE(),27)");
            Sql("INSERT INTO Movies (Name,Genre,ReleaseDate,AddedDate,Stock) VALUES('The Terminator','Action','20101011',GETDATE(),31)");
        }
        
        public override void Down()
        {
        }
    }
}
