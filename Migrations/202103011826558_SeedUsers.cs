namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'05f3f57e-ecba-4ddc-9c74-9cb956400ad9', N'admin@vidly.com', 0, N'AAuvFj79Gwro2hdsbCSfnxo5M+1zg3aLMOWitQeALETWdNXthxAoC2SOlksmzNc5gA==', N'72555033-9fb4-4618-a7a2-5e692d8890e7', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0bac88e7-bc6d-4cb6-9864-1a75327ddf94', N'guest@vidly.com', 0, N'AKAfd/CjicPAXshail7J9rqnFU/OIiRl6pPQkrmjnFjPquMf6CV4s18jqUGK9Zifug==', N'975f2a43-2360-4112-b4f8-73bf3bb7a833', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'af87ca15-e78e-4ce3-b627-6caa7a8b2e00', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'05f3f57e-ecba-4ddc-9c74-9cb956400ad9', N'af87ca15-e78e-4ce3-b627-6caa7a8b2e00')

");
        }
        
        public override void Down()
        {
        }
    }
}
