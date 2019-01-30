namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesAvailabilities : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Availability = Stock");
        }
        
        public override void Down()
        {
        }
    }
}
