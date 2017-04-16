app.directive('myheader', function () {
    return {
        restrict: 'A',
        templateUrl: '../../Content/views/header.html'
    };

});
app.directive('mymenu', function () {
    return {
        restrict: 'A',
        templateUrl: '../../Content/views/menu.html'
    };

});
app.directive('myfooter', function () {
    return {
        restrict: 'A',
        templateUrl: '../../Content/views/footer.html'
    };

});
app.directive('mydelete', function () {
    return {
        restrict: 'A',
        templateUrl: '../../Content/views/borrar.html'
    };

});
app.directive('myedit', function () {
    return {
        restrict: 'A',
        templateUrl: '../../Content/views/editar.html'
    };

});
