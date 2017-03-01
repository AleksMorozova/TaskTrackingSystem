import Constants = require("./task.constants");


var taskConstants = new Constants();


angular
    .module(
    taskConstants.module,
    [
        taskConstants.module,
    ])
    .constant(taskConstants.name, taskConstants)
    .controller(taskConstants.controller, FaceSearchProfileListController)
    .service(taskConstants.service, DetectionProfileService);