"use strict";
import ng = angular;
import Service = require("../../core/services/core.service");
import ITaskService = require("./task.servive.i");

class TaskService implements ITaskService {
    service: Service;
    constructor(service: Service) {
        this.service = service;
    }

    public getAll(): ng.IPromise<any> {
        return this.service.$http({
            method: 'GET',
            url: 'http://localhost:51095/api/user'
        });
    }
}

export = TaskService