'use strict';
Myapp.controller('StudentChangePassController', ['$scope', '$http', 'getsetService', 'ngAuthsetting', function ($scope, $http, getsetService, ngAuthsetting) {
    console.log("Student Change Password Controller is loading...");
    var service = ngAuthsetting.url;
    $scope.StudentData = getsetService.GetData();
    console.log($scope.StudentData.ApplicantID);

    $scope.ChangePassData = function (ChangePass) {
        console.log("update Student CHange Password Record");
        console.log(ChangePass);
        var url = service + "api/studentlogin/changepasswrd";
        var dataToPost = {
            ApplicantID: $scope.StudentData.ApplicantID,
            Password: $scope.StudentData.Password,
            Newpassword: $scope.StudentData.newpass,
            ConfirmNewpassword: $scope.StudentData.confirmpass

        };
        $http.post(url, dataToPost).success(function (data) {
           
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