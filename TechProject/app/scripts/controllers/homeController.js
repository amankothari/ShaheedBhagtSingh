'use strict';
Myapp.controller('homeController', ['$scope', 'ngAuthsetting', '$http', '$location', 'getsetService', 'CourseServices', function ($scope, ngAuthsetting, $http, $location, getsetService, CourseServices) {
    console.log("Home page is loading...");
    var Service = ngAuthsetting.url;
    $scope.GetCourse = [];
    CourseServices.Getcourse().then(function (results) {
        console.log("gett");
        $scope.GetCourse = results.data;
        console.log($scope.GetCourse);
    }, function (error) {

    });


    $scope.reset = function () {
        $scope.Logindata = { userid: '', password: '' };
    }
    $scope.Login = function (Logindata)
    {
        console.log(Logindata.password);
        if ($scope.userForm.$valid)
        {
            var url = Service + "api/studentlogin";
            var dataToPost = {
                ApplicantID: $scope.Logindata.userid,
                Password: $scope.Logindata.password
            };
            console.log("Succesfully");
            console.log(dataToPost);
            $http.post(url, dataToPost).success(function (data) {      
                console.log(data);
                if (data != null)
                {
                    getsetService.Setdata(data);
                    alert("Login is succesfully");
                    $scope.StudentData = getsetService.GetData();
                    console.log($scope.StudentData);
                    window.location = "Home.html#/Dashboard";
                }
                else
                {                 
                    alert("Please enter valid Applicant Id and Password ....!!");
                    $scope.reset();
                }
            })
        .error(function (data) {
            alert("Error Got Here is please enter correct user id and paasword, Note- first time user please your userid as Applicant Id and Password is your full name without any space ");
            console.log("Error Got Here is please enter correct user id and paasword, Note- first time user please your userid as Applicant Id and Password is your full name without any space ");           
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