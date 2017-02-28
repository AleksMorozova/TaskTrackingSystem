define(["require", "exports", "./userModel"], function (require, exports, Model) {
    "use strict";
    var userController = (function () {
        function userController(services, serviceClass) {
            this.serviceFactory = serviceClass;
            this.serviceFactory.assign(services);
            this.users = new Array();
            this.getAll();
        }
        userController.prototype.getAll = function () {
            var self = this;
            this.serviceFactory.getAll()
                .then(function (result) {
                var users = result.data;
                for (var i = 0; i < users.length; i++) {
                    var user = new Model();
                    user.name = users[i].Name;
                    user.lastName = users[i].LastName;
                    self.users.push(user);
                }
            });
        };
        return userController;
    }());
    exports.userController = userController;
});
//# sourceMappingURL=userController.js.map