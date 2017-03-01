import BaseController = require("watch.controllerBase");
import FaceSearchProfileItemController = require("watch.facesearchprofile.item.controller");
import IFaceSearchControllerScope = require("watch.facesearchprofile.list.controller.scope");
import IFaceSearchProfileService = require("watch.facesearchprofile.service.i");

class FaceSearchProfileListController extends BaseController {
    public $scope: IFaceSearchControllerScope;
    public facesearchProfileService: IFaceSearchProfileService;

    public static $inject = [
        "$scope",
        "facesearchprofile.service"
    ];

    constructor(
        $scope: IFaceSearchControllerScope,
        facesearchProfileService: IFaceSearchProfileService) {
        super();

        this.$scope = $scope;
        this.facesearchProfileService = facesearchProfileService;

        this.initialize();
        this.load();
    }


    protected initialize() {

    }

    public load() {
        $("body").addClass("loading");
        var self = this;
        this.facesearchProfileService.find<any>()
            .then(result => {
                var item = result;
                self.$scope.facesearchProfile = new FaceSearchProfileItemController(
                    this.$scope,
                    item);
            })
            .finally(() => { $("body").removeClass("loading"); });
    }


}

export = FaceSearchProfileListController;