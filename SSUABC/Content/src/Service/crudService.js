app.factory('crudGeneral',function($http,$q,$window){
    var crud = {
        get: get,
        post:post
        
    }
    var URL='http://localhost:53880/SS/';
            
    function get(sustantivo){
        var deferred = $q.defer();
        $http.get(URL + sustantivo)
            .then(
            function (response) {
                deferred.resolve(response.data);
            },
            function(errResponse){
                deferred.reject(errResponse);
            }
        );
        return deferred.promise;
    }

    function post(sustantivo, entidad) {
        var deferred = $q.defer();
        $http.post(URL + sustantivo, entidad)
        .then(
        function (response) {
            deferred.resolve(response.data);
        },
            function (errResponse) {
                deferred.reject(errResponse);
            }
    ); return deferred.promise;
    }
    return crud;
    
});