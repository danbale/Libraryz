appController.controller("usuarioCtrl", function ($scope, $location, $rootScope, crudGeneral) {

    $scope.usuarios = []
    $scope.usuario = {};
    $scope.roles = []

    $scope.listarUsuarios = function () {
        crudGeneral.get('Usuario')
            .then(
                function (d) {
                    $scope.usuarios = angular.copy(d);
                    console.log($scope.usuarios)
                },
                function (errResponse) {
                    console.error('Error while fetching Users');
                }
            );
    }
});
