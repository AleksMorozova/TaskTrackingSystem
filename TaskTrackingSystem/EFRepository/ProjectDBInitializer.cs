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
                new UserDB { FirstName = "Rowan", LastName = "Miller", Login = "rowi" });

            context.Users.Add(
                new UserDB { FirstName = "Andrew", LastName = "Peters", Login = "andp" });

            context.Users.Add(
                new UserDB { FirstName = "Brice", LastName = "Lambson", Login = "lamb" });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
