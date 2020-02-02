var WebAspNetAcademyApp = angular.module('WebAspNetAcademyApp',
    ['ui.bootstrap',
        'ui.grid',
    'ngRoute']);

var Globals = new ClientGlobals();


WebAspNetAcademyApp.config(['$routeProvider', function ($routeProvider) {


    $routeProvider.when('/pagina1', {
        templateUrl: "./app/views/Home/menu/pagina1.html",
        controller: "Pagina1Controller"
    });

    $routeProvider.when('/pagina2', {
        templateUrl: "./app/views/Home/menu/pagina2.html",
        controller: "Pagina2Controller"
    });


    $routeProvider.otherwise({
        redirectTo: '/pagina2'
    });

}]);


WebAspNetAcademyApp.controller("Pagina1Controller", ["$scope", function ($scope) {
    $scope.mensaje = "Texto cargado desde el controlador Pagina1Controller";
}]);

WebAspNetAcademyApp.controller("Pagina2Controller", ["$scope", function ($scope) {
    $scope.mensaje = "Texto cargado desde el controlador Pagina2Controller";
}]);







//WebAspNetAcademyApp.config(function ($routeProvider) {
//    $routeProvider
//        .when("Menu", {
//            templateUrl: "./app/views/home/menu/menu.html"
//        })
//});


