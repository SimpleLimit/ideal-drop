(function () {
    "use strict";

    angular.module("images")
        .controller("imageController", imageController);

    function imageController($http) {

        var vm = this;
        vm.rowLimit = 4;

        vm.images = [];
        vm.newImage = {};

        vm.addImage = function () {
            $http.post("/image/upload", vm.newImage)
                .then(function(response) {
                    vm.images.push(response.data);
                    vm.newImage = {};
                }).finally(function() {
                    //busy false
                });

        }
    }
})();