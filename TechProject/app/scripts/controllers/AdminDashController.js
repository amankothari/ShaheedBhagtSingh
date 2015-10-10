'use strict';
Myapp.controller('AdminDashController', ['$scope', '$http', 'StudentRegisterServices', 'CourseServices', function ($scope, $http, StudentRegisterServices, CourseServices) {
    console.log("Admin Dash Controller is loading...");

    $scope.student = [];
    StudentRegisterServices.Getregister().then(function (results) {
        console.log("gett");
        $scope.student = results.data;
    }, function (error) {

    });

    $scope.Course = [];
    CourseServices.Getcourse().then(function (results) {
        console.log("gett Course");
        $scope.Course = results.data;
    }, function (error) {

    });

}]);