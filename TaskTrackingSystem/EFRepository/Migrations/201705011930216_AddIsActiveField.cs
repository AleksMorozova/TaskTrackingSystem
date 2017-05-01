namespace EFRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsActiveField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Histories", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Projects", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Categories", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Issues", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Permissions", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Permissions", "IsActive");
            DropColumn("dbo.Issues", "IsActive");
            DropColumn("dbo.Categories", "IsActive");
            DropColumn("dbo.Projects", "IsActive");
            DropColumn("dbo.Users", "IsActive");
            DropColumn("dbo.Histories", "IsActive");
        }
    }
}
