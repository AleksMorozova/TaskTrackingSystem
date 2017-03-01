namespace EFRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HistoryDBs",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Note = c.String(),
                        Task_Id = c.Guid(),
                        AssignedUser_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IssueDBs", t => t.Task_Id)
                .ForeignKey("dbo.UserDBs", t => t.AssignedUser_Id)
                .Index(t => t.Task_Id)
                .Index(t => t.AssignedUser_Id);
            
            CreateTable(
                "dbo.UserDBs",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Login = c.String(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProjectDBs",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Number = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CategoryDBs",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CategoryTitle = c.String(),
                        Type = c.String(),
                        Addition = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IssueDBs",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Number = c.String(nullable: false),
                        Specification = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        FinishDate = c.DateTime(nullable: false),
                        Priority = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Author_Id = c.Guid(),
                        Category_Id = c.Guid(),
                        CurrentUser_Id = c.Guid(),
                        Project_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserDBs", t => t.Author_Id)
                .ForeignKey("dbo.CategoryDBs", t => t.Category_Id)
                .ForeignKey("dbo.UserDBs", t => t.CurrentUser_Id)
                .ForeignKey("dbo.ProjectDBs", t => t.Project_Id)
                .Index(t => t.Author_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.CurrentUser_Id)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "dbo.RoleDBs",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        UserDB_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserDBs", t => t.UserDB_Id)
                .Index(t => t.UserDB_Id);
            
            CreateTable(
                "dbo.PermissionDBs",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Title = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CategoryDBProjectDBs",
                c => new
                    {
                        CategoryDB_Id = c.Guid(nullable: false),
                        ProjectDB_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.CategoryDB_Id, t.ProjectDB_Id })
                .ForeignKey("dbo.CategoryDBs", t => t.CategoryDB_Id, cascadeDelete: true)
                .ForeignKey("dbo.ProjectDBs", t => t.ProjectDB_Id, cascadeDelete: true)
                .Index(t => t.CategoryDB_Id)
                .Index(t => t.ProjectDB_Id);
            
            CreateTable(
                "dbo.ProjectDBUserDBs",
                c => new
                    {
                        ProjectDB_Id = c.Guid(nullable: false),
                        UserDB_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProjectDB_Id, t.UserDB_Id })
                .ForeignKey("dbo.ProjectDBs", t => t.ProjectDB_Id, cascadeDelete: true)
                .ForeignKey("dbo.UserDBs", t => t.UserDB_Id, cascadeDelete: true)
                .Index(t => t.ProjectDB_Id)
                .Index(t => t.UserDB_Id);
            
            CreateTable(
                "dbo.PermissionDBRoleDBs",
                c => new
                    {
                        PermissionDB_Id = c.Guid(nullable: false),
                        RoleDB_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.PermissionDB_Id, t.RoleDB_Id })
                .ForeignKey("dbo.PermissionDBs", t => t.PermissionDB_Id, cascadeDelete: true)
                .ForeignKey("dbo.RoleDBs", t => t.RoleDB_Id, cascadeDelete: true)
                .Index(t => t.PermissionDB_Id)
                .Index(t => t.RoleDB_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HistoryDBs", "AssignedUser_Id", "dbo.UserDBs");
            DropForeignKey("dbo.RoleDBs", "UserDB_Id", "dbo.UserDBs");
            DropForeignKey("dbo.PermissionDBRoleDBs", "RoleDB_Id", "dbo.RoleDBs");
            DropForeignKey("dbo.PermissionDBRoleDBs", "PermissionDB_Id", "dbo.PermissionDBs");
            DropForeignKey("dbo.ProjectDBUserDBs", "UserDB_Id", "dbo.UserDBs");
            DropForeignKey("dbo.ProjectDBUserDBs", "ProjectDB_Id", "dbo.ProjectDBs");
            DropForeignKey("dbo.HistoryDBs", "Task_Id", "dbo.IssueDBs");
            DropForeignKey("dbo.IssueDBs", "Project_Id", "dbo.ProjectDBs");
            DropForeignKey("dbo.IssueDBs", "CurrentUser_Id", "dbo.UserDBs");
            DropForeignKey("dbo.IssueDBs", "Category_Id", "dbo.CategoryDBs");
            DropForeignKey("dbo.IssueDBs", "Author_Id", "dbo.UserDBs");
            DropForeignKey("dbo.CategoryDBProjectDBs", "ProjectDB_Id", "dbo.ProjectDBs");
            DropForeignKey("dbo.CategoryDBProjectDBs", "CategoryDB_Id", "dbo.CategoryDBs");
            DropIndex("dbo.PermissionDBRoleDBs", new[] { "RoleDB_Id" });
            DropIndex("dbo.PermissionDBRoleDBs", new[] { "PermissionDB_Id" });
            DropIndex("dbo.ProjectDBUserDBs", new[] { "UserDB_Id" });
            DropIndex("dbo.ProjectDBUserDBs", new[] { "ProjectDB_Id" });
            DropIndex("dbo.CategoryDBProjectDBs", new[] { "ProjectDB_Id" });
            DropIndex("dbo.CategoryDBProjectDBs", new[] { "CategoryDB_Id" });
            DropIndex("dbo.RoleDBs", new[] { "UserDB_Id" });
            DropIndex("dbo.IssueDBs", new[] { "Project_Id" });
            DropIndex("dbo.IssueDBs", new[] { "CurrentUser_Id" });
            DropIndex("dbo.IssueDBs", new[] { "Category_Id" });
            DropIndex("dbo.IssueDBs", new[] { "Author_Id" });
            DropIndex("dbo.HistoryDBs", new[] { "AssignedUser_Id" });
            DropIndex("dbo.HistoryDBs", new[] { "Task_Id" });
            DropTable("dbo.PermissionDBRoleDBs");
            DropTable("dbo.ProjectDBUserDBs");
            DropTable("dbo.CategoryDBProjectDBs");
            DropTable("dbo.PermissionDBs");
            DropTable("dbo.RoleDBs");
            DropTable("dbo.IssueDBs");
            DropTable("dbo.CategoryDBs");
            DropTable("dbo.ProjectDBs");
            DropTable("dbo.UserDBs");
            DropTable("dbo.HistoryDBs");
        }
    }
}
