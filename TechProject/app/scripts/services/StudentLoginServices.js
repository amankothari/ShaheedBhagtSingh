'use strict';
Myapp.factory('StudentLoginServices', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var serviceBase = ngAuthSettings.apiServiceBaseUri;

    var loginServicesFactory = {};

    var _Getlogin = function () {
        console.log("in login Service Factory")
        return $http.get(serviceBase + 'api/itemMaster').then(function (results) {
            return results;
        });
    };

    loginServicesFactory.Getlogin = _Getlogin;



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