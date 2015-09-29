'use strict';
Myapp.factory('StudentRegisterServices', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var serviceBase = ngAuthSettings.apiServiceBaseUri;

    var RegisterServicesFactory = {};

    var _Getregister = function () {
        console.log("in Student Register Services Factory")

        return $http.get(serviceBase + 'api/itemMaster').then(function (results) {
            return results;
        });
    };

    RegisterServicesFactory.Getregister = _Getregister;



    var _Putregister = function () {

        return $http.put(serviceBase + 'api/itemMaster').then(function (results) {
            return results;
        });
    };

    RegisterServicesFactory.Putregister = _Putregister;

    //var _deleteitemMaster = function (data) {
    //    console.log("Delete Calling");
    //    console.log(data.ItemId);

    //    return $http.delete(serviceBase + 'api/itemMaster/?id=' + data.ItemId).then(function (results) {
    //        return results;
    //    });
    //};

    //loginServicesFactory.deleteitemMaster = _deleteitemMaster;
    //loginServicesFactory.GetitemMaster = _GetitemMaster;

    return RegisterServicesFactory;

}]);