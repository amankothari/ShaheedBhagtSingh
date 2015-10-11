/// <reference path="../views/website/index.html" />
/// <reference path="controllers/homeController.js" />
'use strict';
var Myapp = angular.module('Myapp', ['ngAnimate', 'ngCookies', 'ngResource', 'ngRoute', 'ngSanitize', 'ngTouch', 'ui.bootstrap', 'angularFileUpload'])
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
        .when('/Register', {
            templateUrl: 'app/views/website/Register.html',
            controller: 'StudentRegisterController'
        })

  //.........Admin..............//

    .when('/Admin/Dashboard', {
        templateUrl: 'app/views/Admin/Dashboard.html',
        controller: 'AdminDashController'
    })

     .when('/Admin/login', {
         templateUrl: 'app/views/Admin/login.html',
         controller: 'AdminLoginController'
     })
    
        .when('/Admin/AddStudent', {
            templateUrl: 'app/views/Admin/AddStudent.html',
            controller: 'AdminAddStudentController'
        })
         .when('/Admin/Student', {
             templateUrl: 'app/views/Admin/Student.html',
             controller: 'AdminAddStudentController'
         })

        .when('/Admin/Faculty', {
            templateUrl: 'app/views/Admin/Faculty.html',
            controller: 'AdminAddStudentController'
        })

         .when('/Admin/AddFaculty', {
             templateUrl: 'app/views/Admin/AddFaculty.html',
             controller: 'AdminAddStudentController'
         })
        .when('/Admin/Staff', {
            templateUrl: 'app/views/Admin/Staff.html',
            controller: 'AdminAddStudentController'
        })

         .when('/Admin/AddStaff', {
             templateUrl: 'app/views/Admin/AddStaff.html',
             controller: 'AdminAddStudentController'
         })

         .when('/Admin/Course', {
             templateUrl: 'app/views/Admin/Course.html',
             controller: 'AddCourseController'
         })

         .when('/Admin/AddCourse', {
             templateUrl: 'app/views/Admin/AddCourse.html',
             controller: 'AddCourseController'
         })

         .when('/Admin/AddStaff', {
             templateUrl: 'app/views/Admin/AddStaff.html',
             controller: 'AdminAddStudentController'
         })

         .when('/Admin/Accountant', {
             templateUrl: 'app/views/Admin/Accountant.html',
             controller: 'AdminAddStudentController'
         })
 //.........End Admin..............//

//.........Student..............//

     .when('/Dashboard', {
         templateUrl: 'app/views/StudentPanel/StudentDash.html',
         controller: 'StudentDashController'
     })
     .when('/UpdateStudent', {
         templateUrl: 'app/views/StudentPanel/UpdateStudent.html',
         controller: 'UpdateStudentController'
     })

        .when('/Uploadfile', {
            templateUrl: 'app/views/StudentPanel/Uploadfile.html',
            controller: 'StudentFileUploadController'
        })

        .when('/Download', {
            templateUrl: 'app/views/StudentPanel/Download.html',
            //controller: 'StudentDetailsController'
        })
     
     .when('/Fee', {
         templateUrl: '/app/views/StudentPanel/Feedetails.html',
         //controller: 'StudentDetailsController'
     })
      .when('/Changepassword', {
          templateUrl: '/app/views/StudentPanel/Changepassword.html',
          //controller: 'StudentDetailsController'
      })

  
 
 });


 var serviceBase = 'http://localhost:49753/';
//var serviceBase = 'http://ngauthenticationapi.azurewebsites.net/';


 Myapp.constant('ngAuthsetting', {
     url: serviceBase
 });


 console.log(Myapp);


 Myapp.controller('CarouselDemoCtrl', function ($scope) {
     console.log(Myapp);
    $scope.myInterval = 5000;
    $scope.slides = [
      {
          image: 'app/images/slide-1.jpg',
          title: 'Better Environment For Better Education'

      },
      {
          image: 'app/images/slide-2.jpg',
          title: 'Improve The Level Of Education Around ICHHAWAR Area'
      },
      {
          image: 'app/images/slide-3.jpg',
          title: 'Job Oriented Courses Running'
      },
      {
          image: 'app/images/slide-4.jpg',
          title: 'Free Education For Financially Week Student'
      }
    ];
 });

 
 Myapp.directive('modal', function () {
     return {
         template: '<div class="modal fade">' +
             '<div class="modal-dialog">' +
               '<div class="modal-content">' +
                 '<div class="modal-header">' +
                   '<button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>' +
                   '<h4 class="modal-title">{{ title }}</h4>' +
                 '</div>' +
                 '<div class="modal-body" ng-transclude></div>' +
               '</div>' +
             '</div>' +
           '</div>',
         restrict: 'E',
         transclude: true,
         replace: true,
         scope: true,
         link: function postLink(scope, element, attrs) {
             scope.title = attrs.title;

             scope.$watch(attrs.visible, function (value) {
                 if (value == true)
                     $(element).modal('show');
                 else
                     $(element).modal('hide');
             });

             $(element).on('shown.bs.modal', function () {
                 scope.$apply(function () {
                     scope.$parent[attrs.visible] = true;
                 });
             });

             $(element).on('hidden.bs.modal', function () {
                 scope.$apply(function () {
                     scope.$parent[attrs.visible] = false;
                 });
             });
         }
     };
 });

 