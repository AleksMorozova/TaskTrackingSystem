require.config({
    paths: {
        angular: "../../Scripts/angular"
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
