var mainApp = angular.module("mainApp", []);
         
mainApp.directive('product', function() {
    var directive = {};
    directive.restrict = 'E'; 
    directive.template = "Student: <b>{{student.name}}</b> , Roll No: <b>{{student.rollno}}</b>";
            
    directive.scope = {
        product : "=name"
    }
            
    directive.compile = function(element, attributes) {       
        var linkFunction = function($scope, element, attributes) {
            element.html("Product Name: <b>" + $scope.product.DescriptionTitle + "</b> ," +
                        "Price No: <b>" + $scope.product.Price + "</b>  <br/>");
    
        }
        return linkFunction;
    }
            
    return directive;
});


mainApp.controller('ProductDetailsController', function ($scope, $location, $http, $rootScope) {
   
    var url = '/api/Product/GetProductDetails';
    $http.get(url, { params: { productId:1 } }).then(function complete(response) {
        $scope.products = response.data;
        
    });
    $scope.Mahesh = {};
    $scope.Mahesh.DescriptionTitle = $scope.products[0].Images[0].ImagesUrl;
    $scope.Mahesh.Price = 1;


    $scope.Piyush = {};
    $scope.Piyush.DescriptionTitle = $scope.products[0].Images[0].ImagesUrl;
    $scope.Piyush.Price = 2;
    alert($scope.products[0].Images[0].ImagesUrl);
   

});