define(["require", "exports", "./model/task.model"], function (require, exports, taskModel) {
    "use strict";
    var TaskController = (function () {
        function TaskController(service) {
            debugger;
            this.taskService = service;
            this.tasks = new Array();
            this.getAll();
        }
        TaskController.prototype.getAll = function () {
            var self = this;
            this.taskService.getAll()
                .then(function (result) {
                var users = result.data;
                for (var i = 0; i < users.length; i++) {
                    var user = new taskModel();
                    user.name = users[i].Name;
                    user.lastName = users[i].LastName;
                    self.tasks.push(user);
                }
            });
        };
        return TaskController;
    }());
    return TaskController;
});
//# sourceMappingURL=task.controller.js.map