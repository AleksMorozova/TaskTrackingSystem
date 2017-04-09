import TaskModel = require("tasks.model");

interface ITaskScope extends ng.IScope {
    tasks: Array<TaskModel>;
    users: Array<User>;
}

class User {
    public name: string;
    public age:number;
}

export = ITaskScope

