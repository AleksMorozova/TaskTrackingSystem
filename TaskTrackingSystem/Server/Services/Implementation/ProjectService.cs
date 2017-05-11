using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Server.Models;
using Services.Contracts;

namespace Server.Services.Implementation
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectContract _contract;
        public ProjectService(IProjectContract contract)
        {
            _contract = contract;
        }
        public void AddProject(ProjectAPIModel projectModel)
        {
            throw new NotImplementedException();
        }

        public void DeleteProject(Guid projectId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProjectAPIModel> GetAllProject()
        {
            return _contract.GetAllProjects().Select(project => new ProjectAPIModel
            {
                Id = project.Id,
                Number = project.Number,
                Title = project.Title,
                Description = project.Description
            }).ToList();
        }

        public void UpdateProject(ProjectAPIModel projectModel)
        {
            throw new NotImplementedException();
        }
    }
}