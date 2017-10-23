app.controller('ShowRegistrationController', function ($scope, $location, RTOServices, ShareData) {
    debugger;
    loadRecords();

    //Function to Load all Employees Records.   
    function loadRecords() {
        var promiseGetRegistrations = RTOServices.getRegistrations();

        promiseGetRegistrations.then(function (pl) { $scope.RegistrationData = pl.data },
              function (errorPl) {
                  $scope.error = 'failure loading Registration', errorPl;
              });
    }


    //Method to route to the addemployee
    $scope.addEmployee = function () {
        $location.path("/addemployee");
    }

    //Method to route to the editEmployee
    //The EmpNo passed to this method is further set to the ShareData
    //This value can then be used to communicate across the Controllers
    $scope.editRegistration = function (RegId) {
        debugger;
        ShareData.value = RegId;
        $location.path("/editregistration");
    }

    //Method to route to the deleteEmployee
    //The EmpNo passed to this method is further set to the ShareData
    //This value can then be used to communicate across the Controllers
    $scope.deleteEmployee = function (EmpNo) {
        ShareData.value = EmpNo;
        $location.path("/deleteemployee");
    }
});