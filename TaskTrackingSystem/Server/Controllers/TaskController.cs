using System;
using System.Collections.Generic;
using System.Web.Http;
using Server.Models;
using Server.Services;

namespace Server.Controllers
{
    [RoutePrefix("api/tasks")]
    public class TaskController : ApiController
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<TaskAPIModel> GetAllTasks()
        {
           return _taskService.GetAllTasks();
        }

        [HttpPost]
        [Route("")]
        public void PostTask([FromBody]TaskAPIModel model)
        {
            _taskService.UpdateTask(model);
        }

        [HttpPut]
        [Route("")]
        public void PutTask([FromBody]TaskAPIModel model)
        {
            _taskService.UpdateTask(model);
        }

        [HttpDelete]
        [Route("")]
        public void DeleteTask(Guid id)
        {
            _taskService.DeleteTask(id);
        }
    }
}
