namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSomeCostumersBirthdays : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = '19960520' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
