app.directive('myheader', function () {
    return {
        restrict: 'A',
        templateUrl: '../../views/header.html'
    };

});
app.directive('mymenu', function () {
    return {
        restrict: 'A',
        templateUrl: '../../views/menu.html'
    };

});
app.directive('myfooter', function () {
    return {
        restrict: 'A',
        templateUrl: '../../views/footer.html'
    };

});
app.directive('mydelete', function () {
    return {
        restrict: 'A',
        templateUrl: '../../views/borrar.html'
    };

});
app.directive('myedit', function () {
    return {
        restrict: 'A',
        templateUrl: '../../views/editar.html'
    };

});
