'use strict';
Myapp.factory('getsetService', function () {
    var tempdata = {};
    var data = {};
   
    return data = {
        GetData: function () {
            return tempdata
        },
        Setdata: function (input) {
            console.log("input");
            console.log(input);
            tempdata = input;
        },

        reset: function () {
            tempdata = {};
        }
    };
})

