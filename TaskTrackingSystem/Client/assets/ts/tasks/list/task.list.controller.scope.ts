import TaskModel = require("tasks.model");

interface ITaskScope extends ng.IScope {
    tasks: Array<TaskModel>;
    sortType: string;
    sortReverse: boolean;
    search: string;
}

export = ITaskScope

