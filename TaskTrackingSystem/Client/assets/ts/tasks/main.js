requirejs.config({
    paths: {
        "jquery": "../../../Scripts/jquery-3.1.1.min",
        "bootstrap": "../../../Scripts/bootstrap",
        "app": "shareApp",
        "angular": "../../../Scripts/angular",
        "ngRoute": "../../../Scripts/angular-route",
        "ngSanitize": "../../../Scripts/angular-sanitize",
        "mainCtrls": "../mainControllers",
        "loginCtrl": "./assets/ts/tasks/loginController",
        "routerCfg": "./assets/ts/tasks/configRouter",
        "serviceFactory": "./assets/ts/tasks/serviceHandler",
        "ui.bootstrap": "../../../Scripts/angular-ui/ui-bootstrap-tpls"
    },
    shim: {
        "ngRoute": ['angular'],
        "ngSanitize": ['angular'],
        "ui.bootstrap": ['angular'],
        "bootstrap": ['jquery']
    }
});
requirejs(["app", "bootstrap", "angular", "ngRoute", "ngSanitize", "ui.bootstrap"], function (app) {
    var shareApp = new app.shareApp();
    angular.element(document).ready(function () {
        angular.bootstrap(document, ['shareApp']);
    });
});
//# sourceMappingURL=main.js.map