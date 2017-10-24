app.controller("EditRegistrationController", function ($scope, $location, ShareData, RTOServices) {

    getRegistration();
    function getRegistration() {
        debugger;
        var promiseGetRegistration = RTOServices.getRegistration(ShareData.value);


        promiseGetRegistration.then(function (pl) {
            $scope.Details = pl.data;
        },
              function (errorPl) {
                  $scope.error = 'failure loading Registration', errorPl;
              });
    }


    //The Save method used to make HTTP PUT call to the WEB API to update the record

    $scope.save = function () {
        if (validate()) {
            var Details = {
                Email: $scope.Details.Email,
                Owner: $scope.Details.Owner,
                Manufacture: $scope.Details.Manufacturer,
                Vehicle: $scope.Details.Vehicle,
                ChasisNo: $scope.Details.ChasisNo,
                Engine: $scope.Details.Engine,
                Color: $scope.Details.color,
                Email: $scope.Details.Email,
                Address: $scope.Details.Address,
                Mobile: $scope.Details.Mobile,
                TempRegistrationNo: $scope.Details.TempRegistrationNo
            }
            var promisePutRegistration = RTOServices.putRegistration($scope.Details.RegId, Details);
            promisePutRegistration.then(function (pl) {
                $location.path("/showregistration");
            },
                  function (errorPl) {
                      $scope.error = 'failure loading registration', errorPl;
                  });
        }
    };

});