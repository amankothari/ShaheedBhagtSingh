'use strict';
Myapp.controller('StudentDashController', ['$scope', '$http', 'getsetService', function ($scope, $http, getsetService) {
    console.log("Student Dash board Controller is loading...");

    $scope.StudentData = getsetService.GetData();
    console.log($scope.StudentData);

    $scope.SignOut = function (SignOut) {
        alert("You Log Out Succesfully");
        getsetService.reset();
        window.location = "#/index";
    }
}]);