import TaskService = require("tasks.service");
import TaskModel = require("tasks.model");
import ITaskScope = require("task.list.controller.scope");
import BaseController = require("baseController");

class TaskListController extends BaseController {
    public $scope: ITaskScope;
    public taskService: TaskService;

    public static $inject = [
        "$scope",
        "task.service"
    ];

    constructor(
        $scope: ITaskScope,
        taskService: TaskService
    ) {
        super();
        debugger;
        this.$scope = $scope;
        this.taskService = taskService;
        this.$scope.tasks = new Array();
        this.load();
    }

    public load() {
        //this.taskService.find<Array<TaskModel>>().then(responce => {
        //    for (var i = 0; i < responce.length; i++) {
        //        this.$scope.tasks.push(responce[i]);
        //    }
        //});
        debugger;
        //this.tableParams.
        //this.tableParams = new a({
        //    sorting: { name: "asc" }
        //});

        this.$scope.users = [
            { name: "Moroni", age: 50 },
            { name: "Tiancum", age: 43 },
            { name: "Jacob", age: 27 },
            { name: "Nephi", age: 29 },
            { name: "Enos", age: 34 }
        ];
    }
}

export = TaskListController;