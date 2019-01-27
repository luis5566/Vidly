namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'11f1a62e-d3a9-4e9c-a63d-dad55581de3e', N'admin@vidly.com', 0, N'AIIGdOP/hiy87RNa4LqgSRy+ZqpPLv4wE99l6YpOswdELpOcllYnzBsfuloL09KG3g==', N'2368e535-427f-4a5c-9d8a-f922e0d5f676', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'16b0d61b-fc09-4ca1-81ab-78b74629fb4b', N'guest@vidly.com', 0, N'AFu4hNxyv7nQFvxjJRovDMtXmuNdlGDhd0l6Nlcm78CReDjEzMW6GkqDopZtHckM8g==', N'9075eab1-f43e-4a88-9a6c-ae3bd1b9b774', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'69211994-6be3-4143-b6ee-b094c0822e47', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'11f1a62e-d3a9-4e9c-a63d-dad55581de3e', N'69211994-6be3-4143-b6ee-b094c0822e47')
");
        }
        
        public override void Down()
        {
        }
    }
}
