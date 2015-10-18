
'use strict';
Myapp.controller('courseController', ['$scope','CourseServices',  function ($scope,CourseServices) {
    console.log("course Controller is loading...");

    $scope.GetCourse = [];
    CourseServices.Getcourse().then(function (results) {
        console.log("gett");
        $scope.GetCourse = results.data;
        console.log($scope.GetCourse);
    }, function (error) {

    });

}]);