namespace LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class workingwithuseraccounts : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "UserId", c => c.Int(nullable: false));
        }
    }
}
