'use strict';
Myapp.factory('StudentLoginServices', ['$http', function ($http) {


    var loginServicesFactory = {};

    var _GetStudentlogin = function () {
        console.log("in Student login Service Factory")
        return $http.get('http://localhost:49753/api/stquery/all').then(function (results) {
            return results;
        });
    };

    loginServicesFactory.GetStudentlogin = _GetStudentlogin;



    var _Putlogin = function () {

        return $http.put(serviceBase + 'api/itemMaster').then(function (results) {
            return results;
        });
    };

    loginServicesFactory.Putlogin = _Putlogin;

    //var _deleteitemMaster = function (data) {
    //    console.log("Delete Calling");
    //    console.log(data.ItemId);

    //    return $http.delete(serviceBase + 'api/itemMaster/?id=' + data.ItemId).then(function (results) {
    //        return results;
    //    });
    //};

    //loginServicesFactory.deleteitemMaster = _deleteitemMaster;
    //loginServicesFactory.GetitemMaster = _GetitemMaster;

    return loginServicesFactory;

}]);