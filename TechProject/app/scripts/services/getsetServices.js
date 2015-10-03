'use strict';
Myapp.factory('getsetService', function () {
    var tempdata = {};
    var data = {};
    //   var recentitem = $injector.get('recentitem');
    return data = {
        Getdata: function () {
            return tempdata;
        },
        Setdata: function (input) {
            console.log("input");
            console.log(input);

            return input
        },

        reset: function () {
            tempdata = {};
        }
    };
})

