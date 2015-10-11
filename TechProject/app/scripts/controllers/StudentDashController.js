'use strict';
Myapp.controller('StudentDashController', ['$scope', '$http', 'getsetService', function ($scope, $http, getsetService) {
    console.log("Student Dash board Controller is loading...");

   
   var StudentData = getsetService.GetData();
    console.log(StudentData);
}]);