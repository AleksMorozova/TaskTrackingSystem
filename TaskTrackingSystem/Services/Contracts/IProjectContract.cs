using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IProjectContract
    {
        IEnumerable<Project> GetAllProjects();

        void AddProject(Project model);

        void UpdateProject(Project model);

        void DeleteProject(Guid projectId);

        Project FindById(Guid projectId);
    }
}
