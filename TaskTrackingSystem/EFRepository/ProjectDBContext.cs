using EFRepository.DBModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository
{
    public class ProjectDBContext : DbContext
    {
        public ProjectDBContext() : base()
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            Database.SetInitializer<ProjectDBContext>(new ProjectDBInitializer());
        }

        public DbSet<UserDB> Users { get; set; }
        public DbSet<ProjectDB> Projects { get; set; }
        public DbSet<IssueDB> Tasks { get; set; }
        public DbSet<HistoryDB> Histories { get; set; }
        public DbSet<CategoryDB> Settings { get; set; }
        public DbSet<RoleDB> Roles { get; set; }
        public DbSet<PermissionDB> Permissions { get; set; }
    }
}
