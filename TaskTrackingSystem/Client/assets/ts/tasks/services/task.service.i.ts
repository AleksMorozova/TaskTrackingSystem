interface ITaskService {
    find: <T>() => ng.IPromise<T>;
}

export = ITaskService;