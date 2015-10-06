'use strict';
Myapp.controller('StudentFileUploadController', ['$scope', '$http', function ($scope, $http) {
    console.log("Student FileUpload Controller is loading...");

    $scope.stepsModel = [];

    $scope.imageUpload = function(event){
        var files = event.target.files; //FileList object
         
        for (var i = 0; i < files.length; i++) {
            var file = files[i];
            var reader = new FileReader();
            reader.onload = $scope.imageIsLoaded; 
            reader.readAsDataURL(file);
            console.log(file);
        }
    }
  
    $scope.imageIsLoaded = function(e){
        $scope.$apply(function() {
            $scope.stepsModel.push(e.target.result);
         
            console.log($scope.stepsModel);
         })};
}]);
