app.controller('NewRegistrationController', function ($scope, $location, RTOServices) {
    $scope.RegId = 0;
    $scope.save = function () {
        var data = {
            RegId: $scope.RegId,
            Vehicle: $scope.Vehicle,
            Email: $scope.Email,
            Owner: $scope.Owner,
            Manufacturer: $scope.Manufacturer,
            ChasisNo: $scope.ChasisNo,
            Engine: $scope.Engine,
            Color: $scope.Color,
            Email: $scope.Email,
            Address: $scope.Address,
            Mobile: $scope.Mobile,
            TempRegistrationNo:$scope.TempRegistrationNo
        };

        var promisePost = RTOServices.postRegistration(data);


        promisePost.then(function (pl) {
            $scope.RegId = pl.data.RegId;
            alert("Temporary Registration No.  " + pl.data.TempRegistrationNo);
            $location.path("/showregistration");
        },
              function (errorPl) {
                  $scope.error = 'failure loading Registration', errorPl;
              });

    };

});