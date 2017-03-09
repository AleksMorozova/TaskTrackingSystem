require.config({
    paths: {
        angular: "../../../Scripts/angular",
        "task.constants": "task.constants"
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
