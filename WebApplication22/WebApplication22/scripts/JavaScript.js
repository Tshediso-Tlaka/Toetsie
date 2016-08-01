/// <reference path="angular.min.js" />

var app = angular.module("myModule", [])
    .controller("myController", function ($scope)
    {
            var lesley = {
                Firstname : "lesley",
                LastName : "Huma",
                Gender : "Male"
            }
            $scope.leslee = lesley;
    })