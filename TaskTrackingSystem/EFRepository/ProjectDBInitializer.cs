using EFRepository.DBModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository
{
    class ProjectDBInitializer : CreateDatabaseIfNotExists<ProjectDBContext>
    {
        protected override void Seed(ProjectDBContext context)
        {
            context.Users.Add(
                new UserDB { FirstName = "Rowan", LastName = "Miller", Login = "hedr" });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
