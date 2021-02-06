﻿namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateExistingMembershipTypeRecords : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as you go' WHERE DiscountRate = 0");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE DiscountRate = 10");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' WHERE DiscountRate = 15");
            Sql("UPDATE MembershipTypes SET Name = 'Annual' WHERE DiscountRate = 20");
        }
        
        public override void Down()
        {
        }
    }
}
