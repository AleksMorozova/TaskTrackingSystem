using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DomainModel;
using Server.Models;
using Services.Contracts;
using Services.Helpers;

namespace Server.Services.Implementation
{
    public class TaskService : ITaskService
    {
        private readonly IIssueContract _contract;

        public TaskService(IIssueContract contract)
        {
            _contract = contract;
        }
        public IEnumerable<TaskAPIModel> GetAllTasks()
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

        public void AddTask(TaskAPIModel taskModel)
        {
            var issueModel = new Issue
            {
                Status = EnumHelper.ParseEnum<Status>(taskModel.Status),
                CreationDate = DateTime.Now,
                FinishDate = taskModel.FinishDate,
                Number = taskModel.Number,
                Priority = EnumHelper.ParseEnum<Priority>(taskModel.Priority),
                Specification = taskModel.Specification
            };
            //issueModel.Author = new User() {}; // TODO: implement find user
            // issueModel.Category = // TODO: implement find user
            //issueModel.CurrentUser = // TODO: implement find user
            //issueModel.Project = // TODO: implement find user
            _contract.AddIssue(issueModel);
        }

        public void UpdateTask(TaskAPIModel taskModel)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(TaskAPIModel taskModel)
        {
            var issue = _contract.FindById(taskModel.Id);
            _contract.DeleteIssue(issue);
        }

        public void DeleteTask(Guid taskId)
        {
            _contract.DeleteIssue(taskId);
        }
        
    }
}