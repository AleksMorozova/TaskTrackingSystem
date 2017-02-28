define(["require", "exports"], function (require, exports) {
    "use strict";
    var TaskConfig = (function () {
        function TaskConfig() {
        }
        TaskConfig.prototype.configure = function ($routeProvider, $locationProvider) {
            $routeProvider.when("/Register", {
                templateUrl: "PartialViews/Register.html",
                controller: "RegisterController"
            }).when("/Buddies", {
                templateUrl: "PartialViews/Buddies.html",
                controller: "BuddiesController"
            }).when("/Share", {
                templateUrl: "PartialViews/Share.html",
                controller: "ShareController"
            }).otherwise({
                redirectTo: "/"
            });
            $locationProvider.html5Mode({
                enabled: true,
                requireBase: false
            });
        };
        return TaskConfig;
    }());
    return TaskConfig;
});
//# sourceMappingURL=task.config.js.map