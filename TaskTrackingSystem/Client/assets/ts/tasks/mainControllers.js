define(["require", "exports", "task.controller", "task.config", "./services/task.service", "../core/services/core.service"], function (require, exports, taskController, taskConfig, TaskService, Service) {
    "use strict";
    var mainControllers = (function () {
        function mainControllers() {
            var app = angular.module("mainControllers", []);
            var router = new taskConfig();
            app.config(router.configure);
            var taskService = new TaskService(taskService);
            var serviceMod = app.factory("services", ["$http", Service]);
            app.controller('MainController', function () { return new taskController(taskService); });
        }
        return mainControllers;
    }());
    exports.mainControllers = mainControllers;
});
//# sourceMappingURL=mainControllers.js.map