appController.controller("loginCtrl", function ($scope, $location, $rootScope) {
    $scope.usuarios = [{
            'id': 1,
            'nombre': 'Eduardo',
            'apellidoPaterno': 'Escalona',
            'correo': 'a338694@uabc.edu.mx',
            'rol': 'Directivo'
                     },
        {
            'id': 1,
            'nombre': 'Yari',
            'apellidoPaterno': 'Perez',
            'correo': 'yarithza.perez@uabc.edu.mx',
            'rol': 'Directivo'
                     }]

});
