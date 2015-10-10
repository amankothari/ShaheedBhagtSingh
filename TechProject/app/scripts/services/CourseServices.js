'use strict';
Myapp.factory('CourseServices', ['$http', function ($http) {

    
    var courseServiceFactory = {};

    var _Getcourse = function () {
        console.log("in Course Service Factory")

        return $http.get('http://localhost:49753/api/course').then(function (results) {
            return results;
        });
    };

       courseServiceFactory.Getcourse = _Getcourse;



       var _Putcourse = function () {

           return $http.put('http://localhost:49753/api/course').then(function (results) {
            return results;
        });
    };

       courseServiceFactory.Putcourse = _Putcourse;

    //var _deleteitemMaster = function (data) {
    //    console.log("Delete Calling");
    //    console.log(data.ItemId);

    //    return $http.delete(serviceBase + 'api/itemMaster/?id=' + data.ItemId).then(function (results) {
    //        return results;
    //    });
    //};

    //itemMasterServiceFactory.deleteitemMaster = _deleteitemMaster;
    //itemMasterServiceFactory.GetitemMaster = _GetitemMaster;

       return courseServiceFactory;

}]);