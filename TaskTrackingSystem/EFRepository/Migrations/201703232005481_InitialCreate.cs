namespace EFRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Histories",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Note = c.String(),
                        Issue_Id = c.Guid(),
                        AssignedUser_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Issues", t => t.Issue_Id)
                .ForeignKey("dbo.Users", t => t.AssignedUser_Id)
                .Index(t => t.Issue_Id)
                .Index(t => t.AssignedUser_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Login = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Title = c.String(),
                        Number = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CategoryTitle = c.String(),
                        Type = c.String(),
                        Addition = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Issues",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Number = c.String(),
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
                .ForeignKey("dbo.Users", t => t.Author_Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Users", t => t.CurrentUser_Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .Index(t => t.Author_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.CurrentUser_Id)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Title = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CategoryProjects",
                c => new
                    {
                        Category_Id = c.Guid(nullable: false),
                        Project_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Category_Id, t.Project_Id })
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("dbo.Projects", t => t.Project_Id, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "dbo.ProjectUsers",
                c => new
                    {
                        Project_Id = c.Guid(nullable: false),
                        User_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Project_Id, t.User_Id })
                .ForeignKey("dbo.Projects", t => t.Project_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Project_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.PermissionRoles",
                c => new
                    {
                        Permission_Id = c.Guid(nullable: false),
                        Role_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Permission_Id, t.Role_Id })
                .ForeignKey("dbo.Permissions", t => t.Permission_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.Permission_Id)
                .Index(t => t.Role_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Histories", "AssignedUser_Id", "dbo.Users");
            DropForeignKey("dbo.Roles", "User_Id", "dbo.Users");
            DropForeignKey("dbo.PermissionRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.PermissionRoles", "Permission_Id", "dbo.Permissions");
            DropForeignKey("dbo.ProjectUsers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.ProjectUsers", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.Issues", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.Histories", "Issue_Id", "dbo.Issues");
            DropForeignKey("dbo.Issues", "CurrentUser_Id", "dbo.Users");
            DropForeignKey("dbo.Issues", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Issues", "Author_Id", "dbo.Users");
            DropForeignKey("dbo.CategoryProjects", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.CategoryProjects", "Category_Id", "dbo.Categories");
            DropIndex("dbo.PermissionRoles", new[] { "Role_Id" });
            DropIndex("dbo.PermissionRoles", new[] { "Permission_Id" });
            DropIndex("dbo.ProjectUsers", new[] { "User_Id" });
            DropIndex("dbo.ProjectUsers", new[] { "Project_Id" });
            DropIndex("dbo.CategoryProjects", new[] { "Project_Id" });
            DropIndex("dbo.CategoryProjects", new[] { "Category_Id" });
            DropIndex("dbo.Roles", new[] { "User_Id" });
            DropIndex("dbo.Issues", new[] { "Project_Id" });
            DropIndex("dbo.Issues", new[] { "CurrentUser_Id" });
            DropIndex("dbo.Issues", new[] { "Category_Id" });
            DropIndex("dbo.Issues", new[] { "Author_Id" });
            DropIndex("dbo.Histories", new[] { "AssignedUser_Id" });
            DropIndex("dbo.Histories", new[] { "Issue_Id" });
            DropTable("dbo.PermissionRoles");
            DropTable("dbo.ProjectUsers");
            DropTable("dbo.CategoryProjects");
            DropTable("dbo.Permissions");
            DropTable("dbo.Roles");
            DropTable("dbo.Issues");
            DropTable("dbo.Categories");
            DropTable("dbo.Projects");
            DropTable("dbo.Users");
            DropTable("dbo.Histories");
        }
    }
}
