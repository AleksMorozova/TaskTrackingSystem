using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace Services.Implementation
{
    public class ProjectImplementation : IProjectContract
    {
        public void AddProject(Project model)
        {
            throw new NotImplementedException();
        }

        public void DeleteProject(Guid projectId)
        {
            throw new NotImplementedException();
        }

        public Project FindById(Guid projectId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return Registration.ProjectRepository.ReadAll().ToList();
        }

        public void UpdateProject(Project model)
        {
            throw new NotImplementedException();
        }
    }
}
