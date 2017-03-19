using System;
using System.Collections.Generic;
using Server.Models;

namespace Server.Services
{
    public interface ITaskService
    {
        IEnumerable<TaskAPIModel> GetAllTasks();
        void AddTask(TaskAPIModel taskModel);
        void UpdateTask(TaskAPIModel taskModel);
        void DeleteTask(TaskAPIModel taskModel);
        void DeleteTask(Guid taskId);
    }
}
