(function () {
    'use strict';

    angular.module('mainApp').service('dataContext', ['httpService', function (httpService) {
        var service = {
            getRestaurants: getRestaurants,
            GetProductsForRestaurant: getProductsForRestaurant
        };

        function getRestaurants() {
            return httpService.get("api/restaurant");
        }

        function getProductsForRestaurant(idRestaurant) {
            return httpService.get("api/restaurant/products/" + idRestaurant);

        }

        return service;
    }]);

})();