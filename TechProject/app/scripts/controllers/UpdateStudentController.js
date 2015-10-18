'use strict';
Myapp.controller('UpdateStudentController', ['$scope', 'ngAuthsetting', '$http', 'getsetService', 'StudentLoginServices', function ($scope, ngAuthsetting, $http, getsetService, StudentLoginServices) {
    console.log("Student Register 1111 Controller is loading...");
    var serviceBase = ngAuthsetting.url;
      $scope.Loginstudent =  getsetService.GetData();
   
    $scope.UpdateStudentData = function (Register) {
        console.log("Add Register data");
        console.log(Register);
        var url = serviceBase + "api/studentlogin";
        
        $http.put(url, Register).success(function (data) {
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