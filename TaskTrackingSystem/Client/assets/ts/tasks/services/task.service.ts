import ITaskService = require("tasks.service.i");
import TaskConstants = require("tasks.constant");
import CommonConstants = require("commonConstants");

class TaskService implements ITaskService {

    public static $inject = [
        "$http",
        "task.constants",
        "common.constants"
    ];

    private httpService: ng.IHttpService;
    private taskConstants: TaskConstants;
    private commonConstants: CommonConstants;

    constructor(httpService: ng.IHttpService,
        taskConstants: TaskConstants,
        commonConstants: CommonConstants) {
        this.taskConstants = taskConstants;
        this.commonConstants = commonConstants;
        this.httpService = httpService;
    }

    find<T>(): angular.IPromise<T> {
        return this.httpService.get(this.commonConstants.api + this.taskConstants.api)
            .then(response => {
                return response.data;
            });
    }


}

export = TaskService