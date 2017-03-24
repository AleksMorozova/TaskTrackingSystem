import TaskModel = require("tasks.model");

interface ITaskScope extends ng.IScope {
    tasks: Array<TaskModel>;
}

export = ITaskScope

