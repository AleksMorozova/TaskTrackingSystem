import TaskConstants = require("tasks.constant");
import TaskService = require("tasks.service");
import TaskListController = require("tasks.list.controller");
import CommonConstants = require("commonConstants");

var taskConstants = new TaskConstants();
var commonConstants = new CommonConstants();


angular
    .module(
    taskConstants.module,
    [
        taskConstants.module
    ])
    .constant(taskConstants.name, taskConstants)
    .constant(commonConstants.name, commonConstants)
    .controller(taskConstants.controller, TaskListController)
    .service(taskConstants.service, TaskService);