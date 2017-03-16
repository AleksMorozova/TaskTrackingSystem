declare module "baseController" {
    import exportedModule = require("controllerBase");
    export =exportedModule;
}

declare module "commonConstants" {
    import exportedModule = require("common.constants");
    export =exportedModule;
}