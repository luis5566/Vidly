namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedAvailabilityToLong : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Availability", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Availability", c => c.Int(nullable: false));
        }
    }
}
