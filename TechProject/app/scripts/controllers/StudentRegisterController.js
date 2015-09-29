'use strict';
Myapp.controller('StudentRegisterController', ['$scope', '$http', function ($scope, $http) {
    console.log("Student Register 1111 Controller is loading...");

    $scope.RegisterData = function (Register) {
        console.log("Add Register data");
        console.log(Register);
        var url = "http://localhost:49753/api/stquery";
        //var dataToPost = {
        //    EmailId: $scope.Logindata.userid,
        //    Password: $scope.Logindata.Password
        //};
        $http.post(url, Register).success(function (data) {
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