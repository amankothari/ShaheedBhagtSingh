'use strict';
Myapp.factory('StudentLoginServices', ['$http','ngAuthsetting', function ($http,ngAuthsetting) {

    var url = ngAuthsetting.url;

    var loginServicesFactory = {};

    var _GetStudentlogin = function () {
        console.log("in Student login Service Factory")
        return $http.get(url + 'api/stquery/all').then(function (results) {
            return results;
        });
    };

    loginServicesFactory.GetStudentlogin = _GetStudentlogin;



    var _Putlogin = function () {

        return $http.put(url + 'api/stquery').then(function (results) {
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