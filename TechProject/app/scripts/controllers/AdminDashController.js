'use strict';
Myapp.controller('AdminDashController', ['$scope', '$http', 'StudentRegisterServices', function ($scope, $http, StudentRegisterServices) {
    console.log("Admin Dash Controller is loading...");

    $scope.student = [];
    StudentRegisterServices.Getregister().then(function (results) {
        console.log("gett");
        $scope.student = results.data;
    }, function (error) {

    });

}]);