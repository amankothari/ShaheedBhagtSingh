﻿'use strict';
Myapp.controller('StudentRegisterController', ['$scope', 'ngAuthsetting', '$http', 'StudentRegisterServices', function ($scope, ngAuthsetting, $http, StudentRegisterServices) {
    console.log("Student Register 1111 Controller is loading...");
    var serviceBase = ngAuthsetting.url;
   
    $scope.student = [];
    StudentRegisterServices.Getregister().then(function (results) {
        console.log("gett");
        $scope.student = results.data;
        }, function (error) {

    });

    $scope.RegisterData = function (Register) {
        console.log("Add Register data");
        console.log(Register);
        var url = serviceBase + "api/stquery";
        //var dataToPost = {
        //    EmailId: $scope.Logindata.userid,
        //    Password: $scope.Logindata.Password
        //};
        $http.post(url, Register).success(function (data) {
            console.log(data);
            alert("You have Register Succesfully, we will contact you on your mobile Number..");

            window.location = "#/index";
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