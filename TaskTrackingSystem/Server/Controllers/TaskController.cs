using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Server.Controllers
{
    [RoutePrefix("api/task")]
    public class TaskController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IEnumerable<Task> GetUsers()
        {
            var tasks = new List<Task>
            {
                new Task
                {
                    Name = "Name",
                    Notes = "LastName"
                },
                new Task
                {
                    Name = "Name1",
                    Notes = "LastName1"
                },
                new Task
                {
                    Name = "Name2",
                    Notes = "LastName2"
                },
                new Task
                {
                    Name = "Name3",
                    Notes = "LastName3"
                },
                new Task
                {
                    Name = "Name4",
                    Notes = "LastName4"
                }
            };

            return tasks;
        }
    }

    public class Task
    {
        public string Name { get; set; }

        public string Notes { get; set; }
    }
}
