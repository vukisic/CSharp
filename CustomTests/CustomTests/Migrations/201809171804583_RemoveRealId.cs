namespace CustomTests.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRealId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.People", "RealId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "RealId", c => c.Int(nullable: false));
        }
    }
}
