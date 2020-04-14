namespace Invite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddId : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Guests");
            AddColumn("dbo.Guests", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Guests", "Name", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Guests", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Guests");
            AlterColumn("dbo.Guests", "Name", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Guests", "Id");
            AddPrimaryKey("dbo.Guests", "Name");
        }
    }
}
