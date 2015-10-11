'use strict';
Myapp.controller('AddCourseController', function ($scope, $http, CourseServices,ngAuthsetting) {
    console.log("Add Course  Controller is loading...");
    console.log(ngAuthsetting);
    $scope.showModal = false;
    $scope.toggleModal = function () {
        $scope.showModal = !$scope.showModal;
    };

    $scope.GetCourse = [];
    CourseServices.Getcourse().then(function (results) {
        console.log("gett");
        $scope.GetCourse = results.data;
    }, function (error) {

    });

    $scope.AddCourse = function (Course) {
        console.log("Add Course data");
        console.log(Course);
        var url = "api/course";
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
