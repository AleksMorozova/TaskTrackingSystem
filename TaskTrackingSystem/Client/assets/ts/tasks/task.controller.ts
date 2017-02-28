"use strict";
import taskModel = require("./model/task.model");
import TaskService = require("./services/task.service");

class TaskController {
    taskService: TaskService;
    tasks: Array<taskModel>;

    constructor(service: TaskService) {
        debugger;
        this.taskService = service;
        this.tasks = new Array<taskModel>();
        this.getAll();

    }

    private getAll() {
        var self = this;
        this.taskService.getAll()
            .then(result => {
                var users = result.data;
                for (var i = 0; i < users.length; i++) {
                    var user = new taskModel();
                    user.name = users[i].Name;
                    user.lastName = users[i].LastName;
                    self.tasks.push(user);
                }
            });
    }
}

export = TaskController