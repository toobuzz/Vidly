namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameDataMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("update dbo.membershiptypes set Name = 'Pay as You Go' where id = 1");
            Sql("update dbo.membershiptypes set Name = 'Monthly' where id = 2");
            Sql("update dbo.membershiptypes set Name = 'Quarterly' where id = 3");
            Sql("update dbo.membershiptypes set Name = 'Yearly' where id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
