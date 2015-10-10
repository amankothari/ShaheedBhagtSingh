'use strict';
Myapp.controller('homeController', ['$scope', '$http', '$location', 'getsetService', function ($scope, $http, $location, getsetService) {
    console.log("Home page is loading...");
   
    $scope.reset = function () {
        $scope.Logindata = { userid: '', password: '' };
    }

    $scope.Login = function (Logindata)
    {
        console.log(Logindata.password);
        if ($scope.userForm.$valid)
        {
            var url = "api/studentlogin";
            var dataToPost = {
                ApplicantID: $scope.Logindata.userid,
                Password: $scope.Logindata.password
            };
            console.log("Succesfully");
            console.log(dataToPost);
            $http.post(url, dataToPost).success(function (data) {
                console.log(data);
                alert("Login is succesfully");
                getsetService.Setdata(data);
                window.location = "Home.html#/Dashboard";
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
            alert("Error Got Here is please enter correct user id and paasword, Note- first time user please your userid as Applicant Id and Password is your full name without any space ");
            console.log("Error Got Here is please enter correct user id and paasword, Note- first time user please your userid as Applicant Id and Password is your full name without any space ");
            console.log(data);
            $scope.reset();
        })
        }    
        else
        {
            alert("There are invalid fields");
            $scope.reset();
        }

    };



   
        // function to submit the form after all validation has occurred			
       
}]);