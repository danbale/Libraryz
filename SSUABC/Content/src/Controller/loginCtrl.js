appController.controller("loginCtrl", function ($scope, $location, $rootScope, crudGeneral) {
    $scope.mensajeDTO = {}

    $scope.usuarioDTO = {
        "Id": "",
        "Correo": "",
        "Rol":{"Id":"","Nombre":""},
        "Nombre": "",
        "Apellido": "",
        "Contrasenia": "",
        "Numero_Empleado":""
    }
    
    $scope.IniciarSesion = function () {
        crudGeneral.post('Login',$scope.usuarioDTO)
           .then(
               function (d) {
                   $scope.mensajeDTO = angular.copy(d.Respuesta);
                   console.log($scope.mensajeDTO);
                   if ($scope.mensajeDTO.Entidad != null) {
                       $rootScope.loggedUser = angular.copy($scope.mensajeDTO.Entidad);
                       console.log($rootScope.loggedUser);
                       alert($scope.mensajeDTO.Mensaje);
                       $location.path('/SS/Inicio');
                   } else {
                       alert($scope.mensajeDTO.Mensaje);
                       $location.path('/login');
                   }

                   
               },
               function (errResponse) {
         
               }
           );
    }
        
});
