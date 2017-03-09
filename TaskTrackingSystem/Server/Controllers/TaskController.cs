using System.Collections.Generic;
using System.Web.Http;
using DomainModel;
using Services.Contracts;

namespace Server.Controllers
{
    [RoutePrefix("api/tasks")]
    public class TaskController : ApiController
    {
        private readonly IIssueContract _contract;

        public TaskController(IIssueContract contract)
        {
            _contract = contract;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Issue> GetAllItems()
        {
            return _contract.GetAllIssues();
        }
    }
}
