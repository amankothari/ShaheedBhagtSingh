'use strict';
Myapp.controller('StudentDashController', ['$scope', '$http', 'getsetService', function ($scope, $http, getsetService) {
    console.log("Student Dash board Controller is loading...");

    $scope.StudentData = [];
    $scope.StudentData = getsetService.Getdata();
    console.log($scope.StudentData);
}]);