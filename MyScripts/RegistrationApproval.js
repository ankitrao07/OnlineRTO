app.controller('ApproveRegistrationController', function ($scope, $location, RTOServices, ShareData) {
   
    loadRecords();

    //Function to Load all Registrations Records.   
    function loadRecords() {
        var pendingGetRegistrations = RTOServices.getPendingRegistrations();

        pendingGetRegistrations.then(function (pl) { $scope.RegistrationData = pl.data },
              function (errorPl) {
                  $scope.error = 'failure loading Registration', errorPl;
              });
    }


     //Method to route to the Approve the Registration
    //The RegId passed to this method is further set to the ShareData
    //This value can then be used to communicate across the Controllers
    $scope.Approve = function (RegId) {
        ShareData.value = RegId;
        $location.path("/editregistration");
    }
       
});