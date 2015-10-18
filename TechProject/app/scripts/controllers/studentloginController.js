'use strict';
Myapp.controller('StudentLoginController', ['$scope', '$http', 'ngAuthsetting', 'StudentLoginServices', '$Location', function ($scope, $http, ngAuthsetting, StudentLoginServices, $Location) {
    console.log("Login Controller is loading...");
    var serviceBase = ngAuthsetting.url;
    $scope.Login = function (Logindata) {   
            console.log("Add itemMaster");
            console.log(data);
            var url = serviceBase + "api/studentLogin";
            var dataToPost = {
                EmailId: $scope.Logindata.userid,
               Password:$scope.Logindata.Password             
            };
            console.log("Succesfully");
            console.log(dataToPost);
            $Location.url="";

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