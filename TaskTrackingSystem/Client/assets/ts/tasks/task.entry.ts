require.config({
    paths: {
        angular: "../../../Scripts/angular",
        "controllerBase":"../../common/controllerBase",
        "tasks.service": "services/task.service",
        "tasks.service.i": "services/task.service.i",
        "tasks.constant": "task.constants",
        "tasks.list.controller": "list/task.list.controller",
        "tasks.model": "models/task.model",
        "task.list.controller.scope": "list/task.list.controller.scope",
        "baseController": "../common/controllerBase",
        "commonConstants":"../common/common.constants"
    },
    shim: {
        jquery: { exports: "jquery" },
        angular: { exports: "angular" }
    }
});
require([
    "angular",
    "task.module"
], angular => {
    $(() => {
        angular.bootstrap(document, ["task.module"]);
    });
});
