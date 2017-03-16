declare module "tasks.service" {
    import exportedModule = require("services/task.service");
    export =exportedModule;
}

declare module "tasks.service.i" {
    import exportedModule = require("services/task.service.i");
    export =exportedModule;
}

declare module "tasks.constant" {
    import exportedModule = require("task.constants");
    export =exportedModule;
}

declare module "tasks.list.controller" {
    import exportedModule = require("list/task.list.controller");
    export =exportedModule;
}

declare module "tasks.model" {
    import exportedModule = require("models/task.model");
    export =exportedModule;
}

declare module "task.list.controller.scope" {
    import exportedModule = require("list/task.list.controller.scope");
    export =exportedModule;
}
