using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Server.Models;
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
        public IEnumerable<TaskAPIModel> GetAllItems()
        {
            return _contract.GetAllIssues().Select(issue => new TaskAPIModel
            {
                Id = issue.Id,
                AuthorName = issue.Author?.FirstName,
                Category = issue.Category?.CategoryTitle,
                CreationDate = issue.CreationDate,
                Status = issue.Status.ToString(),
                CurrentUserName = issue.CurrentUser?.FirstName,
                FinishDate = issue.FinishDate,
                Number = issue.Number,
                Priority = issue.Priority.ToString(),
                ProjectName = issue.Project.Title,
                Specification = issue.Specification
            }).ToList();
        }
    }
}
