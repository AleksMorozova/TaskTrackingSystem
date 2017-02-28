define(["require", "exports", "./task.module"], function (require, exports, taskModule) {
    "use strict";
    var shareApp = (function () {
        function shareApp() {
            var ngApp = angular.module('shareApp', ["ngRoute", "ngSanitize", "ui.bootstrap", "taskModule"]);
            var mainCtrls = new taskModule(null);
        }
        return shareApp;
    }());
    exports.shareApp = shareApp;
});
//# sourceMappingURL=shareApp.js.map