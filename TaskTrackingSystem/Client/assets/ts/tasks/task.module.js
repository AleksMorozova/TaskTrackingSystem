define(["require", "exports", "task.controller", "task.config", "./services/task.service"], function (require, exports, taskController, taskConfig, TaskService) {
    "use strict";
    var TaskModule = (function () {
        function TaskModule(service) {
            var _this = this;
            var app = angular.module("taskModule", ["ngRoute", "ngSanitize", "ui.bootstrap"]);
            var router = new taskConfig();
            app.config(router.configure);
            this.taskService = new TaskService(service);
            //var serviceMod = app.factory("services", ["$http", Service]);
            app.controller('TaskController', function () { return new taskController(_this.taskService); });
        }
        return TaskModule;
    }());
    return TaskModule;
});
//# sourceMappingURL=task.module.js.map