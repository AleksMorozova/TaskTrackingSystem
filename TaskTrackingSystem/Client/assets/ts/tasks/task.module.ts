"use strict";
import ng = angular;
import taskController = require("task.controller");
import taskConfig = require("task.config");
import TaskService = require("./services/task.service");
import Service = require("../core/services/core.service");

class TaskModule {
    private taskService: TaskService;
    constructor(service: Service) {
        var app = angular.module("taskModule", ["ngRoute", "ngSanitize", "ui.bootstrap"]);
        var router = new taskConfig();
        app.config(router.configure);

        this.taskService = new TaskService(service);
        //var serviceMod = app.factory("services", ["$http", Service]);
        app.controller('TaskController', () => new taskController(this.taskService));
    }
}

export  = TaskModule