'use strict';
Myapp.controller('AdminLoginController', ['$scope', '$location', function ($scope, $location) {
    console.log("Admin Login Controller page is loading...");
   
  
    $scope.AdminLogin = function (Logindata) {
        console.log("Post Admin Data");
        console.log(data);
        var url =  "api/admin";
        var dataToPost = {
            EmailId: $scope.Logindata.userid,
            Password: $scope.Logindata.password
        };
        console.log("Succesfully");
        console.log(dataToPost);
        $Location.url = "#/Admin/Dashboard";

        $http.post(url, dataToPost)
        .success(function (data) {
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
         .error(function (data) {
             console.log("Error Got Heere is ");
             console.log(data);

         })
    };
}]);