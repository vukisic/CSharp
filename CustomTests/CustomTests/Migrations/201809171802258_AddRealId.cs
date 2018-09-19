namespace CustomTests.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRealId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "RealId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "RealId");
        }
    }
}
