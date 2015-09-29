'use strict';
Myapp.controller('homeController', ['$scope', '$location', function ($scope, $location) {
    console.log("Home page is loading...");
   
    $scope.Login = function (Logindata) {
        console.log("Add itemMaster");
        var name = 'mipscollege@gmail.com';
        var password = 12345;
        if(Logindata.userid==name)
        {
            if (Logindata.password == password)
            {
                window.location = "Home.html#/Dashboard";
                console.log(password);
            }
            else
            {
                $scope.msg = "Please enter correct password..!";
                console.log($scope.msg);
            }
        }
        else {
            $scope.msg = "Please enter correct User id..!";
            console.log($scope.msg);
        }
        //var url = serviceBase + "api/studentLogin";
        //var dataToPost = {
        //    EmailId: $scope.Logindata.userid,
        //    Password: $scope.Logindata.Password
        //};
        //console.log("Succesfully");
        //console.log(dataToPost);
        //$Location.url = "";

        //$http.post(url, dataToPost)
        //.success(function (data) {
        //    console.log(data);
        //    console.log("Error Gor Here");
        //    console.log(data);

        //    if (data.id == 0) {

        //        $scope.gotErrors = true;
        //        if (data[0].exception == "Already") {
        //            console.log("Got This User Already Exist");
        //            $scope.AlreadyExist = true;
        //        }

        //    }
        //    else {


        //    }

        //})
        // .error(function (data) {
        //     console.log("Error Got Heere is ");
        //     console.log(data);

        // })
    };
}]);