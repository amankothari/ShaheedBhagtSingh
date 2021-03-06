﻿'use strict';
Myapp.controller('AddCourseController', function ($scope, $http, CourseServices,ngAuthsetting) {
    console.log("Add Course  Controller is loading...");

    var SurviceBase = ngAuthsetting.url;

    $scope.showModal = false;
    $scope.EditData = {};
    $scope.Edit = function (getcourse) {
        $scope.showModal = !$scope.showModal;
        console.log(getcourse);
        $scope.EditData = getcourse;
        $scope.SaveEditCourse = function (EditData) {
            console.log(EditData);
            var url = SurviceBase + "api/course";
            $http.put(url, EditData).success(function (data) {
                console.log(data);
              
                $scope.showModal = !$scope.showModal;
                
                console.log(data);
                if (data.id == 0) {
                    $scope.gotErrors = true;
                    if (data[0].exception == "Already") {
                        console.log("Got This User Already Exist");
                        $scope.AlreadyExist = true;
                    }
                }
                else { }
            })}
    };

    $scope.GetCourse = [];
    CourseServices.Getcourse().then(function (results) {
        console.log("gett");
        $scope.GetCourse = results.data;
        console.log($scope.GetCourse);
    }, function (error) {

    });

    $scope.AddCourse = function (Course) {
        console.log("Add Course data");
        console.log(Course);
        var url = SurviceBase + "api/course";
        $http.post(url, Course).success(function (data) {
            console.log(data);
            alert("You Succesfully Add Course");
            window.location = "Home.html#/Admin/Course";
            console.log(data);
            if (data.id == 0) {

                $scope.gotErrors = true;
                if (data[0].exception == "Already") {
                    console.log("Got This User Already Exist");
                    $scope.AlreadyExist = true;
                }

            }
            else {


            }

        })
    }
});
