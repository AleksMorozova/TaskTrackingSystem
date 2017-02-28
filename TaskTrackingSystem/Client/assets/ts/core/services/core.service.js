define(["require", "exports"], function (require, exports) {
    "use strict";
    var CoreService = (function () {
        function CoreService($http) {
            this.$http = $http;
            return this;
        }
        return CoreService;
    }());
    return CoreService;
});
//# sourceMappingURL=core.service.js.map