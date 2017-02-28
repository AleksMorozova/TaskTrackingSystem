class CoreService {
    $http: any;
    constructor($http: ng.IHttpService) {
        this.$http = $http;
        return this;
    }
}

export = CoreService