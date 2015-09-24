var appname = angular.module('Sequence', []);

appname.controller('processSequence', ['$scope',
  function ($scope,$http) {
      $scope.name = "Farrukh Khan";
      $scope.data = [{
          title : "Title, This is 1 message",
          body : "this body",
          created : "12"
      } ,
         {
             title : "Title, This is 2 message",
             body : "this 2 body",
             created : "12"
         } ,
          {
              title : "Title, This is 3 message",
              body : "this 3 body",
              created : "12"
          } 
      ];
  }]);

(function () {

    var app = angular.module("Sequence", []);

    var loginCtrl = function ($scope, loginService) {
        $scope.user = {
            uservalue: '1',
            error: '',
            numbers: '',
            odd_Numbers: '',
            even_Numbers: '',
            custom_Numbers: '',
            fibonacci_Numbers: ''

        };
        //Calling a service
        $scope.onUserSubmit = function (value) {
            loginService.getNumberSequence(value)
            .then(userComplete, errorResponse);
        };
        //On promise back success
        var userComplete = function (response) {

            $scope.user.numbers = response.numbers;
            $scope.user.odd_Numbers = response.oddnumbers;
            $scope.user.even_Numbers = response.evennumbers;
            $scope.user.custom_Numbers = response.customnumbers;
            $scope.user.fibonacci_Numbers = response.fibonaccinumbers;
            $scope.user.error = response.message;
            console.log("success");

        };
        //on promise back failure
        var errorResponse = function (response) {

            $scope.user.error = response;
            console.log("failure");
        };

    };
    //registering controller
    app.controller("processSequence", loginCtrl);
}());