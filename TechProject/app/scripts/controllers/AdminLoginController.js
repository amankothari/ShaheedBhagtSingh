'use strict';
Myapp.controller('AdminLoginController', ['$scope', '$location', 'AdminGetSetService', function ($scope, $location, AdminGetSetService) {
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
        $http.post(url, dataToPost)
        .success(function (data) {
            console.log(data);
            AdminGetSetService.Setdata(data);
            $Location.url = "#/Admin/Dashboard";
            if (data.id == 0) {
                $scope.gotErrors = true;
                if (data[0].exception == "Already") {
                    console.log("Got This User Already Exist");
                    $scope.AlreadyExist = true;
                }
            }
            else
            {
            }
        })
         .error(function (data) {
             alert("Your User id or Password is not match ");
             console.log("Error Got Heere is ");        
         })
    };
}]);