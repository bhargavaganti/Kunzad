﻿// app.js

var kunzadApp = angular.module('kunzadApp', ['ngRoute', 'ng-context-menu', 'ui.bootstrap']);

kunzadApp.config(['$routeProvider', function ($routeProvider) {
        //Setup routes to load partial templates from server. TemplateUrl is the location for the server view (Razor .cshtml view)
        $routeProvider

            .when('/home', {
                templateUrl: '/Home/_Main'
            })

            .when('/customers', {
                templateUrl: '/References/Customers',
                controller: 'CustomerController'
            })

            .when('/customergroups', {
                templateUrl: '/References/CustomerGroups',
                controller: 'CustomerGroupController'
            })

            .otherwise({
                redirectTo: '/home'
            });
    }])

    .controller('RootController', ['$rootScope', '$scope', '$route', '$routeParams', '$location', '$http',
        function ($rootScope, $scope, $route, $routeParams, $location, $http) {

            $scope.$on('$routeChangeSuccess', function (e, current, previous) {
                $scope.activeViewPath = $location.path();
            });

            $rootScope.cityMunicipalities = [];

            // Get List of CityMunicipalities
            var getCityMunicipalities = function () {
                //alert("get");
                $http.get("/api/CityMunicipalities")
                    .success(function (data, status) {
                        //alert("success");
                        $rootScope.cityMunicipalities = data;
                    })
                    .error(function (data, status) {
                    });
            }

            function init() {
                getCityMunicipalities();
            }

            init();

    }]);


// -------------------------------------------------------------------------//
// Open Modal Panel - Use in DataTable //
function openModalPanel (panelName) {
    //Open Modal Form/Panel
    jQuery.magnificPopup.open({
        removalDelay: 500, //delay removal by X to allow out-animation,
        items: { src: panelName },
        callbacks: {
            beforeOpen: function (e) {
                var Animation = "mfp-flipInY";
                this.st.mainClass = Animation;
            },
            afterClose: function () {
            }
        },
        midClick: true // allow opening popup on middle mouse click. Always set it to true if you don't provide alternative source.
    })
}


// -------------------------------------------------------------------------//
// Usage for spin.js
var opts = {
    lines: 11, // The number of lines to draw
    length: 11, // The length of each line
    width: 4, // The line thickness
    radius: 11, // The radius of the inner circle
    corners: 1, // Corner roundness (0..1)
    rotate: 0, // The rotation offset
    direction: 1, // 1: clockwise, -1: counterclockwise
    color: '#000', // #rgb or #rrggbb or array of colors
    speed: 1, // Rounds per second
    trail: 46, // Afterglow percentage
    shadow: false, // Whether to render a shadow
    hwaccel: false, // Whether to use hardware acceleration
    className: 'spinner', // The CSS class to assign to the spinner
    zIndex: 2e9, // The z-index (defaults to 2000000000)
    top: '50%', // Top position relative to parent
    left: '50%' // Left position relative to parent
};
var spinnerTarget = document.getElementById('spinnerTarget');
