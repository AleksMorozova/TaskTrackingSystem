import Controller = require("../common/controllerBase");
import Service = require("./services/task.service");

class TaskController extends Controller {
    public $scope: ITaskScope;
    public facesearchProfileService: Service;

    public static $inject = [
        "$scope",
        "task.service"
    ];

    constructor(
        $scope: ITaskScope,
        facesearchProfileService: Service) {
        super();

        this.$scope = $scope;
        this.facesearchProfileService = facesearchProfileService;

        this.initialize();
        this.load();
    }


    protected initialize() {

    }

    public load() {
        this.$scope.Message = "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
    }


}

export = TaskController;


interface ITaskScope extends ng.IScope {
    Message: string;
}