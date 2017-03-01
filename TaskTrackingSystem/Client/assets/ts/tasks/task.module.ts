import Constants = require("./task.constants");
import Service = require("./services/task.service");
import Controller = require("./task.controller");
var taskConstants = new Constants();


angular
    .module(
    taskConstants.module,
    [
        taskConstants.module,
    ])
    .constant(taskConstants.name, taskConstants)
    .controller(taskConstants.controller, Controller)
    .service(taskConstants.service, Service);