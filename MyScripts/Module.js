    var app = angular.module("ApplicationModule", ["ngRoute"]);

    
    app.factory("ShareData", function () {
        return { value: 0 }
    });

    //Defining Routing
    app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
        $routeProvider.when('/showregistration',
                           {
                               templateUrl: 'Dealer/ShowRegistration',
                               controller: 'ShowRegistrationController'
                           }); 
       $routeProvider.when('/newregistration',
                                             {
                                                 templateUrl: 'Dealer/NewRegistrationForm',
                                                 controller: 'NewRegistrationController'
                                             });

       $routeProvider.when("/editregistration",
                          {
                              templateUrl: 'Dealer/EditRegistration',
                              controller: 'EditRegistrationController'
                          });

       $routeProvider.when('/showpendingRegistration',
                            {
                                
                                templateUrl: 'RTO/ShowPendingRegistration',
                                controller: 'ApproveRegistrationController'
                            });

       $routeProvider.when('/Logout',
                          {
                              templateUrl: 'Account/Logout',
                              controller:'LogoutController'
                          });
        $routeProvider.otherwise(
                            {
                                redirectTo: '/'
                            });
       // $locationProvider.html5Mode(true);
        $locationProvider.html5Mode(true).hashPrefix('!')
    }]);