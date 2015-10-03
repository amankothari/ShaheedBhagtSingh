'use strict';
Myapp.controller('AdminLoginController', ['$scope', '$location', function ($scope, $location) {
    console.log("Admin Login Controller page is loading...");
   
    $scope.AdminLogin = function (Login) {
        console.log(Login);
        console.log("Login");
        window.location = "#/Admin/Dashboard";
        var name = 'mipscollege@gmail.com';
        var password = 12345;
        //if (Login.userid == name) {
        //    if (Login.password == password) {
               
        //        console.log(password);
        //    }
        //    else {
        //        $scope.msg = "Please enter correct password..!";
        //        console.log($scope.msg);
        //    }
        //}
        //else {
        //    $scope.msg = "Please enter correct User id..!";
        //    console.log($scope.msg);
        //}
       
    };
}]);