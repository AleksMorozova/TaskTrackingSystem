define(["require", "exports"], function (require, exports) {
    "use strict";
    var TaskService = (function () {
        function TaskService(service) {
            this.service = service;
        }
        TaskService.prototype.getAll = function () {
            return this.service.$http({
                method: 'GET',
                url: 'http://localhost:51095/api/user'
            });
        };
        return TaskService;
    }());
    return TaskService;
});
//# sourceMappingURL=task.service.js.map