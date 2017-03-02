using EFRepository.DBModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            ProjectDB project = new ProjectDB { Title = "First project", Number = "P-1" };
            context.Projects.Add(project);

            context.SaveChanges();

            context.Users.Add(
                new UserDB
                {
                    FirstName = "Rowan",
                    LastName = "Miller",
                    Login = "rowi",
                    Projects = new BindingList<ProjectDB>() { project }
                });

            context.Users.Add(
                new UserDB
                {
                    FirstName = "Andrew",
                    LastName = "Peters",
                    Login = "andp",
                    Projects = new BindingList<ProjectDB>() { project }
                });

            context.Users.Add(
                new UserDB
                {
                    FirstName = "Brice",
                    LastName = "Lambson",
                    Login = "lamb",
                    Projects = new BindingList<ProjectDB>() { project }
                });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
