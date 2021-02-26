(function () {
    'use strict';

    angular.module('mainApp').controller('homeController', ['dataContext',function (dataContext) {
        var vm = this;

        vm.list = null;
        var i;

        console.log("aici");

        vm.apasa = function () {
            console.log("M-ai apasat");
        };

        dataContext.getRestaurants().then(
            function (response) {
                //console.log(response.data);
                vm.list = response.data;

                for (i = 0; i < vm.list.length; i++) {
                    console.log(vm.list[i].id);
                    dataContext.getProductsForRestaurant(vm.list[i].id).then(
                        function (response) {
                            console.log(response.data);
                        },
                        function (err) {
                            console.log(err);
                        }
                    );
                }
            },
            function (err) {
                console.log(err);
            }
        )


    }]);

})();