import ITaskService = require("./task.service.i");

class TaskService implements ITaskService {

    public static $inject = [
        "$http"
    ];

    public httpService: ng.IHttpService;

    constructor(httpService: ng.IHttpService) {
        this.httpService = httpService;
    }

    find<T>(): angular.IPromise<T> {
        return this.httpService.get('http://localhost:4737/api/ProductInfoAPI')
            .then(response => {
                return response.data;
            });
    }
}

export = TaskService