import ITaskService = require("./task.service.i");

class TaskService implements ITaskService {

    constructor() {
        
    }

    find<T>(): angular.IPromise<T> {
        return this.httpService.apiGet<any>(this.faceSearchProfileConstants.api + this.faceSearchProfileConstants.faceSearchProfile)
            .then(response => {
                return response.data;
            });

    }
}

export = TaskService