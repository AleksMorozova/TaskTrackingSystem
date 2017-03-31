using DomainModel;
using System;
using System.Data.Entity;

namespace EFRepository
{
    class ProjectDBInitializer : CreateDatabaseIfNotExists<ProjectDBContext>
    {
        protected override void Seed(ProjectDBContext context)
        {
            Project project = new Project { Title = "First project", Number = "P-1" };
            context.Projects.Add(project);

            context.SaveChanges();

            User firstdUser = new User
            {
                FirstName = "Rowan",
                LastName = "Miller",
                Login = "rowi",
            };
            context.Users.Add(firstdUser);

            User secondUser = new User
            {
                FirstName = "Andrew",
                LastName = "Peters",
                Login = "andp",
            };
            context.Users.Add(secondUser);

            User thirdUser = new User
            {
                FirstName = "Brice",
                LastName = "Lambson",
                Login = "lamb",
            };
            context.Users.Add(thirdUser);
            context.SaveChanges();

            Issue firstTask = new Issue
            {
                Number = "F-1",
                Priority = Priority.Minor,
                Status = Status.InProcess,
                Author = firstdUser,
                CurrentUser = secondUser,
                Specification = "first task",
                CreationDate = DateTime.Now,
                FinishDate = DateTime.Now
            };

            Issue secondTask = new Issue
            {
                Number = "F-2",
                Priority = Priority.Minor,
                Status = Status.InProcess,
                Author = firstdUser,
                CurrentUser = secondUser,
                CreationDate = DateTime.Now,
                FinishDate = DateTime.Now
            };

            Issue thirdTask = new Issue
            {
                Number = "F-3",
                Priority = Priority.Minor,
                Status = Status.InProcess,
                Author = thirdUser,
                CurrentUser = secondUser,
                CreationDate = DateTime.Now,
                FinishDate = DateTime.Now
            };

            context.Tasks.Add(firstTask);
            context.Tasks.Add(secondTask);
            context.Tasks.Add(thirdTask);
            context.SaveChanges();

            project.Issues.Add(firstTask);
            project.Issues.Add(secondTask);
            project.Issues.Add(thirdTask);

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
