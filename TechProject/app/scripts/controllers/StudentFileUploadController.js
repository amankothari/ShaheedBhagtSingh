'use strict';
Myapp.controller('StudentFileUploadController', ['$scope', 'ngAuthsetting', '$http', 'getsetService', function ($scope, ngAuthsetting, $http, getsetService) {
    console.log("Student FileUpload Controller is loading...");
    var Service = ngAuthsetting.url;
    $scope.imageModel = [];
    $scope.stepsModel = [];
    var Filedata = [];
    $scope.imageUpload = function(event){
        var files = event.target.files; //FileList object
         
        for (var i = 0; i < files.length; i++) {
            var file = files[i];
            var reader = new FileReader();
            reader.onload = $scope.imageIsLoaded; 
            reader.readAsDataURL(file);
            Filedata = file;
            console.log(Filedata);
            console.log("file");
        }
    }
  
    $scope.imageIsLoaded = function(e){
        $scope.$apply(function () {
            $scope.imageModel = e.target.result;
            $scope.stepsModel.push(e.target.result);
         
            console.log($scope.stepsModel);
        })
    };

    $scope.Delete = function (step) {
        $scope.step.splice(idx, 1);
    };



    $scope.Save = function (event) {
        console.log("Filedata");
        var url = Service + "api/studentlogin/update";
           console.log("Succesfully");
           console.log(Filedata.name);
           console.log($scope.imageModel);
           var dataToPost = {
               //ApplicantID: $scope.Logindata.userid,
               //Password: $scope.Logindata.password
           };
           $http.post(url, dataToPost).success(function (data) {
               alert("Login is succesfully");
               $scope.StudentData = getsetService.GetData();
               console.log($scope.StudentData);
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

        }
   
}]);
