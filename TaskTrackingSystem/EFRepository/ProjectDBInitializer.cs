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

            UserDB firstdUser = new UserDB
            {
                FirstName = "Rowan",
                LastName = "Miller",
                Login = "rowi",
                Projects = new BindingList<ProjectDB>() { project }
            };
            context.Users.Add(firstdUser);

            UserDB secondUser = new UserDB
            {
                FirstName = "Andrew",
                LastName = "Peters",
                Login = "andp",
                Projects = new BindingList<ProjectDB>() { project }
            };
            context.Users.Add(secondUser);

            UserDB thirdUser = new UserDB
            {
                FirstName = "Brice",
                LastName = "Lambson",
                Login = "lamb",
                Projects = new BindingList<ProjectDB>() { project }
            };
            context.Users.Add(thirdUser);
            context.SaveChanges();

            IssueDB firstTask = new IssueDB
            {
                Number = "F-1",
                Priority = PriorityDB.Minor,
                Status = StatusDB.InProcess,
                Author = firstdUser,
                CurrentUser = secondUser,
                Specification = "first task",
                CreationDate = DateTime.Now,
                FinishDate = DateTime.Now
            };

            IssueDB secondTask = new IssueDB
            {
                Number = "F-2",
                Priority = PriorityDB.Minor,
                Status = StatusDB.InProcess,
                Author = firstdUser,
                CurrentUser = secondUser,
                CreationDate = DateTime.Now,
                FinishDate = DateTime.Now
            };

            IssueDB thirdTask = new IssueDB
            {
                Number = "F-3",
                Priority = PriorityDB.Minor,
                Status = StatusDB.InProcess,
                Author = thirdUser,
                CurrentUser = secondUser,
                CreationDate = DateTime.Now,
                FinishDate = DateTime.Now
            };

            context.Tasks.Add(firstTask);
            context.Tasks.Add(secondTask);
            context.Tasks.Add(thirdTask);
            context.SaveChanges();

            project.Tasks.Add(firstTask);
            project.Tasks.Add(secondTask);
            project.Tasks.Add(thirdTask);

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
