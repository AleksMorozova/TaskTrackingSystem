using System;
using System.Collections.Generic;
using System.Web.Http;
using Server.Models;
using Server.Services;

namespace Server.Controllers
{
    [RoutePrefix("api/projects")]
    public class ProjectController : ApiController
    {
        private readonly IProjectService _projectService;
    
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<ProjectAPIModel> GetAllProjects()
        {
            return _projectService.GetAllProject();
        }

        [HttpPost]
        [Route("")]
        public void PostProject([FromBody]ProjectAPIModel model)
        {

        }

        [HttpPut]
        [Route("")]
        public void PutProject(Guid id, [FromBody]ProjectAPIModel model)
        {

        }

        [HttpDelete]
        [Route("")]
        public void DeleteProject(Guid id)
        {

        }
    }
}
