/// <reference path="../views/website/index.html" />
/// <reference path="controllers/homeController.js" />
'use strict';
var Myapp = angular.module('Myapp', ['ngAnimate', 'ngCookies', 'ngResource', 'ngRoute', 'ngSanitize', 'ngTouch', 'ui.bootstrap'])
 Myapp.config(function ($routeProvider) {
    return $routeProvider.when("/", {
        redirectTo: "/index"
    })
        .when('/index', {
            templateUrl: 'app/views/website/index.html',
            controller: 'homeController'
        })
        .when('/Courses', {
            templateUrl: 'app/views/website/Courses.html',
            //controller: 'courseController'
        })

          .when('/AboutUs', {
              templateUrl: 'app/views/website/AboutUs.html',
              //controller: 'StudentDetailsController'
          })

         .when('/contact', {
             templateUrl: 'app/views/website/contact.html',
             //controller: 'StudentDetailsController'
         })

         .when('/News', {
             templateUrl: 'app/views/website/News.html',
             //controller: 'StudentDetailsController'
         })

        .when('/Team', {
            templateUrl: 'app/views/website/Team.html',
            //controller: 'StudentDetailsController'
        })


    .when('/Admin/Dashboard', {
        templateUrl: 'app/views/Admin/Dashboard.html',
        //controller: 'StudentDetailsController'
    })

     .when('/Admin/login', {
         templateUrl: 'app/views/Admin/login.html',
         controller: 'AdminLoginController'
     })
    .when('/Admin/StudentData', {
        templateUrl: 'Admin/views/StudentData.html',
        //controller: 'AdminStudentDataController'
    })

     .when('/Dashboard', {
         templateUrl: 'app/views/StudentPanel/StudentDash.html',
         //controller: 'StudentDetailsController'
     })
     .when('/UpdateStudent', {
         templateUrl: 'app/views/StudentPanel/UpdateStudent.html',
         //controller: 'StudentDetailsController'
     })
     .when('/Register', {
         templateUrl: 'app/views/website/Register.html',
         controller: 'StudentRegisterController'
     })
     .when('/Fee', {
         templateUrl: '/app/views/StudentPanel/Feedetails.html',
         //controller: 'StudentDetailsController'
     })

    //// route for the contact page
    //.when('/contact', {
    //    templateUrl: 'pages/contact.html',
    //    controller: 'contactController'
    //});
 });
 console.log(Myapp);
 Myapp.controller('CarouselDemoCtrl', function ($scope) {
     console.log(Myapp);
    $scope.myInterval = 5000;
    $scope.slides = [
      {
          image: 'app/images/slide-1.jpg',
          title: 'Come to our Open Days'

      },
      {
          image: 'app/images/slide-2.jpg',
          title: 'Come to our Open Days'
      },
      {
          image: 'app/images/slide-3.jpg',
          title: 'Come to our Open Days'
      },
      {
          image: 'app/images/slide-4.jpg',
          title: 'Come to our Open Days'
      }
    ];
});