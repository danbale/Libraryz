app.factory('crudGeneral',function($http,$q,$window){
    var crud = {
            get:get
    }
    var URL='http://localhost:53880/SS/Usuario';
            
    function get(sustantive){
        var deferred = $q.defer();
        $http.get(URL)
            .then(
            function (response) {
                deferred.resolve(response.data);
            },
            function(errResponse){
                console.error('Error while fetching Users');
                deferred.reject(errResponse);
            }
        );
        return deferred.promise;
    }
    return crud;
    
});