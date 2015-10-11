'use strict';
Myapp.controller('StudentChangePassController', ['$scope', '$http', 'getsetService', function ($scope, $http, getsetService) {
    console.log("Student Change Password Controller is loading...");

    $scope.StudentData = getsetService.GetData();
    console.log($scope.StudentData.ApplicantID);

    $scope.ChangePassData = function (ChangePass) {
        console.log("update Student CHange Password Record");
        console.log(ChangePass);
        var url = "api/studentlogin";
        var dataToPost = {
            ApplicantID: $scope.StudentData.ApplicantID,
            Password: ChangePass.newpass
        };
        $http.put(url, dataToPost).success(function (data) {
           
            alert("You Have Change Password Succesfully, your password is " + data.Password+ " Kindly save it for the Future use");
            window.location = "Home.html#/Dashboard";
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