using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Services
{
    public interface IProjectService
    {
        IEnumerable<ProjectAPIModel> GetAllProject();
        void AddProject(ProjectAPIModel projectModel);
        void UpdateProject(ProjectAPIModel projectModel);
        void DeleteProject(Guid projectId);
    }
}