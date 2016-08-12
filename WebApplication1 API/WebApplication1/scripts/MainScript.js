var OnlineShop = angular.module('OnlineShopApp', ['ngRoute']);

OnlineShop.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.

    when('/HomePage', {
        templateUrl: 'HomePage.html', //we can set an already existing page and it will be displayed.
        controller: 'HomePageController'
    }).
    when('/Catalogue', {
        templateUrl: 'Catalogue.htm',
        controller: 'CatalogueController'
    }).

    when('/ContactUs', {
        templateUrl: 'ContactUs.htm',
        controller: 'ContactUsController'
    }).

    when('/ProductDetails', {
        templateUrl: 'ProductDetails.htm',
        controller: 'ProductDetailsController'
    }).
        
    otherwise({
        redirectTo: '/HomePage'
    });
}]);



OnlineShop.controller('CatalogueController', function ($scope, $http, $rootScope) {
    $scope.subFilter = {};
    var url = '/api/AccordionSideBar/GetCategories';
    $http.get(url).then(function complete(response) {
        $scope.categories = response.data.Categories;
        $scope.subCategories = response.data.Subcategories;
    });

    $scope.ShowBySubCategory = function (subId) {
        var url = '/api/Product/GetCatalogueProducts';
        $http.get(url, { params: { subCategoryId: subId } }).then(function complete(response) {
            $scope.products = response.data;
        });
    }
    $scope.FilterBySubId = function (subId) {
        $scope.subFilter=subId;
    }
});

OnlineShop.controller('ContactUsController', function ContactUsController($scope, $http, $rootScope) {

    $scope.contactUsData = {};

    $scope.sendContactDetails = function () {

        var url = '/api/ContactUs/OnSend';

        $http.post(url, $scope.contactUsData).then(function complete(response) {
            $scope.contactUsData = null;
            $scope.messageSent = true;
            $scope.result = 'true';
        });
    }
    $scope.notification = function () {
        $scope.result = 'false';
    }


});

OnlineShop.controller('HomePageController', function ($scope, $http) {
    $scope.messageSent = false;
    $scope.contactUsData = {};
    $scope.sendContactDetails = function () {

        var url = '/api/ContactUs/OnSend';
        $http.post(url, $scope.contactUsData).then(function complete(response) {
            $scope.contactUsData = null;
            $scope.messageSent = true;
            $scope.result = 'true';
        });
        $scope.notification = function () {
            $scope.result = 'false';
        }
    }
    var url = '/api/Carousel/GetCarousels';
    $http.get(url).then(function complete(response) {
        $scope.carousels = response.data;
    });

    url = '/api/News/GetNews';
    $http.get(url).then(function complete(response) {
        $scope.news = response.data;
    })

    url = '/api/HotDeals/GetHotDeals';
    $http.get(url).then(function complete(response) {
        $scope.hotDeals = response.data;
    })


});

OnlineShop.controller('ProductDetailsController', function ($scope, $location, $http, $rootScope) {

    var url = '/api/Product/GetProductDetails';
    $http.get(url, { params: { productId: $location.search().productId } }).then(function complete(response) {
        $scope.products = response.data;
        $scope.mainImageSource = $scope.products[0].Images[0].ImagesUrl;
 });

    $scope.ChangeMainImage = function (imageUrl) {
        $scope.mainImageSource = imageUrl;
    }

});

OnlineShop.controller('MenuController', function ($scope, $http) {
    var url = '/api/Menu/GetMenu';
    $http.get(url).then(function complete(response) {
        $scope.menuTabs = response.data;
    });
});

OnlineShop.controller('FooterController', function ($scope, $http) {
    var url = '/api/Footer/GetFooter';
    $http.get(url).then(function complete(response) {
        $scope.footerTabs = response.data;
    });
});