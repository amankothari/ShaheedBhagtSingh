'use strict';
Myapp.controller('AdminLoginController', ['$http', '$scope', '$location', 'AdminGetSetService', 'ngAuthsetting', function ($http, $scope, $location, AdminGetSetService, ngAuthsetting) {
    var url = ngAuthsetting.url;
    console.log("Admin Login Controller page is loading...");

    $scope.LoginData = function (LoginData) {
        console.log(LoginData);
        var post = {
            UserName: LoginData.applicantid,
            Password: LoginData.password
        }
        var url1 = url + "api/login/in";
        $http.post(url1, post).success(function (data)
        {  
         if (data != null)
         {
             console.log(data);
             AdminGetSetService.Setdata(data);
             window.location = "#/Admin/Dashboard";
         
         }
         else {
             alert("Your User id or Password is not match ");
         }
     })
      .error(function (data)
      {
          alert("Your User id or Password is not match ");
          console.log("Error Got Heere is ");
      })

    }
}]);