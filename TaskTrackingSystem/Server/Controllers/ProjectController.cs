using System;
using System.Collections.Generic;
using System.Web.Http;
using Server.Models;

namespace Server.Controllers
{
    [RoutePrefix("api/projects")]
    public class ProjectController : ApiController
    {
        public ProjectController()
        {

        }

        [HttpGet]
        [Route("")]
        public IEnumerable<ProjectAPIModel> GetAllProjects()
        {
            return null;
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
