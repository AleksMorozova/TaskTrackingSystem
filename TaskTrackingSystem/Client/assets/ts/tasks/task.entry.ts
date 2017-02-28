requirejs.config({
    paths: {
        "jquery": "../../../Scripts/jquery-3.1.1.min",
        "bootstrap": "../../../Scripts/bootstrap",
        "app": "task.module",
        "angular": "../../../Scripts/angular",
        "ngRoute": "../../../Scripts/angular-route",
        "ngSanitize": "../../../Scripts/angular-sanitize",
        "ui.bootstrap": "../../../Scripts/angular-ui/ui-bootstrap-tpls",
    },
    shim: {
        "ngRoute": ['angular'],
        "ngSanitize": ['angular'],
        "ui.bootstrap": ['angular'],
        "bootstrap": ['jquery']
    }
});

requirejs(["app", "bootstrap", "angular", "ngRoute", "ngSanitize", "ui.bootstrap"], (app) => {
    var taskModule = new app();

    angular.element(document).ready(() => {
        angular.bootstrap(document, ['taskModule']);
    });
});