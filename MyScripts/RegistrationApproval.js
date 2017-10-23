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
        debugger;
        ShareData.value = RegId;
        var Details = {
            Status: 'Approve'
        }
        var promiseApproveRegistration = RTOServices.approveRegistration(RegId, Details);
        promiseApproveRegistration.then(function (pl) {
            // $location.path("/showregistration");
            alert("Registered Successfully !!!");
            $location.path("/showpendingRegistration");
        },
              function (errorPl) {
                  $scope.error = 'failure loading registration', errorPl;
              });
    }
    
       
});