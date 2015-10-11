'use strict';
Myapp.controller('AdminDashController', ['$scope', '$http', 'StudentRegisterServices', 'CourseServices', function ($scope, $http, StudentRegisterServices, CourseServices) {
    console.log("Admin Dash Controller is loading...");
    $scope.showModal = false;
    $scope.student = [];
    StudentRegisterServices.Getregister().then(function (results) {
        console.log("gett");
        $scope.student = results.data;
        console.log($scope.student);
    }, function (error) {

    });

    //$scope.Course = [];
    //CourseServices.Getcourse().then(function (results) {
    //    console.log("gett Course");
    //    $scope.Course = results.data;
    //    console.log($scope.Course);
    //}, function (error) {

    //});
    $scope.EditData = {};
    $scope.ViewStudentQuery = function (stu) {
        $scope.showModal = !$scope.showModal;
        $scope.EditData = stu;
        console.log(stu);
        $scope.Save = function (Save) {
        $scope.showModal = !$scope.showModal;

        }

    }

}]);