var app = angular.module("app", ['ngRoute', 'app.controllers']);
app.config(function ($routeProvider) {
    $routeProvider
        .when('/', {
            templateUrl: '../Content/views/login.html',
            controller: 'loginCtrl'
        })
        .when('/login', {
            templateUrl: '../Content/views/login.html',
            controller: 'loginCtrl'
        })
        .when('/logout', {
            templateUrl: '../Content/views/inactivo.html',
        })
        .when('/SS/usuario/listar', {
            templateUrl: '../Content/views/listar.html',
            controller: 'usuarioCtrl'

        })
        .when('/SS/Inicio', {
            templateUrl: '../Content/views/inicio.html',
        })
        .when('/SS/usuario/agregar', {
            templateUrl: '../Content/views/usuario.html',
        })
        .otherwise({
            redirectTo: '/login'
        })

});

app.run(function ($rootScope, $location) {
    $rootScope.$on("$routeChangeStart", function (event, next, current) {
        if ($rootScope.loggedUser == null) {
            // no logged user, we should be going to #login
            if (next.templateUrl == "/login") {
                // already going to #login, no redirect needed
            } else {
                // not going to #login, we should redirect now
                $location.path("/login");
            }
        }
    });
})
