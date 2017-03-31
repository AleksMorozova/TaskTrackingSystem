using System.Data.Entity;
using DomainModel;

namespace EFRepository
{
    public class ProjectDBContext : DbContext
    {
        public ProjectDBContext()
        {
            Database.SetInitializer(new ProjectDBInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Issue> Tasks { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Category> Settings { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
    }
}
