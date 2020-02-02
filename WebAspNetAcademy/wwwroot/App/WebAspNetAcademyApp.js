var WebAspNetAcademyApp = angular.module('WebAspNetAcademyApp',
    ['ui.bootstrap',
        'ui.grid',
    'ngRoute']);

var Globals = new ClientGlobals();


WebAspNetAcademyApp.config(['$routeProvider', function ($routeProvider) {

    $routeProvider.when('/main', {
        templateUrl: "./app/views/Home/menu/menu.html",
        controller: "MenuController"
    });


    $routeProvider.when('/students', {
        templateUrl: "./app/views/Home/menu/students/students.html",
        controller: "StudentsController"
    });

    $routeProvider.when('/subjects', {
        templateUrl: "./app/views/Home/menu/subjects/subjects.html",
        controller: "SubjectsController"
    });


    $routeProvider.otherwise({
        redirectTo: '/main'
    });

}]);


WebAspNetAcademyApp.controller("StudentsController", ["$scope", function ($scope) {
    $scope.mensaje = "Texto cargado desde el controlador StudentsController";
}]);

WebAspNetAcademyApp.controller("SubjectsController", ["$scope", function ($scope) {
    $scope.mensaje = "Texto cargado desde el controlador SubjectsController";
}]);

WebAspNetAcademyApp.controller("MenuController", ["$scope", function ($scope) {
    $scope.mensaje = "Texto cargado desde el controlador MenuController";
}]);








//WebAspNetAcademyApp.config(function ($routeProvider) {
//    $routeProvider
//        .when("Menu", {
//            templateUrl: "./app/views/home/menu/menu.html"
//        })
//});


