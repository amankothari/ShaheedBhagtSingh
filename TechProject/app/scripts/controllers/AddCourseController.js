'use strict';
Myapp.controller('AddCourseController', ['$scope', '$http', function ($scope, $http) {
    console.log("Add Course  Controller is loading...");

    $scope.AddCourse = function (Course) {
        console.log("Add Course data");
        console.log(Course);
        var url = "api/course";
       
        $http.post(url, Course).success(function (data) {
            console.log(data);
            console.log("Error Gor Here");
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
}]);
