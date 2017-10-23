app.service("RTOServices", function ($http) {

    this.getRegistrations = function () {
        return $http.get("/api/RegistrationAPI");
    };

    
    //Fundction to Read Registration based upon id
    this.getRegistration = function (id) {
        debugger;
        return $http.get("/api/RegistrationAPI/" + id);
    };

    this.postRegistration = function (data) {
        var request = $http({
            method: "post",
            url: "/api/RegistrationAPI",
            data: data
        });
        return request;
    }; 

    //Function  to Edit Regisration details based upon id 
    this.putRegistration = function (RegId, Details) {
        var request = $http({
            method: "put",
            url: "/api/RegistrationAPI/" + RegId,
            data: Details
        });
        return request;
    };

    //RTO role Scripts here to approve or reject the Regisration Request
    this.getPendingRegistrations=function()
    {
        debugger;
        return $http.get("api/RTOAPI");
    }
});








