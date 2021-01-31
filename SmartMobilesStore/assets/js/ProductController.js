app.controller("ProductController", function ($scope, $http) {

    $scope.getProdList = [];
    $scope.getProductList = [];
    $scope.getBulkProductList = [];
    $scope.singleProductImage = [];

    $scope.getLatestProducts = function () {
        $http.post("/Product/GetNewProductsList").then(function (response) {
            $scope.getProdList = response.data;
        }
            ,
            function (error) {
                alert("failure in getdata");
            }

        )
    }
    //list of products on homepage
    $scope.getFeaturedProducts = function () {
        $http.post("/Product/GetProductsList").then(function (response) {

            $scope.getProductList = response.data.filter(i => i.FeatureType == 2 && i.PageType==1);
            $scope.singleProductImage = response.data.filter(i => i.FeatureType == 5 && i.PageType == 1);
        }
            ,
            function (error) {
                alert("failure in getdata");
            }

        )
    }
    //list of products on ProductList Page
    $scope.getProductsList = function () {
        $http.post("/Product/GetProductsList").then(function (response) {
            $scope.getBulkProductList = response.data;
        }
            ,
            function (error) {
                alert("failure in getdata");
            }

        )
    }
    //To get the color Filter results
    $scope.blueColorFilter = function () {
        $http.post("/Product/GetBlueColorFilter").then(function (response) {
            $scope.getBulkProductList = response.data;
        }
            ,
            function (error) {
                alert("failure in getdata");
            }

        )
    }

    //To get the color Filter results
    $scope.blackColorFilter = function () {
        $http.post("/Product/GetBlackColorFilter").then(function (response) {
            $scope.getBulkProductList = response.data;
        }
            ,
            function (error) {
                alert("failure in getdata");
            }

        )
    }
    //To get the color Filter results

    $scope.redColorFilter = function () {
        $http.post("/Product/GetRedColorFilter").then(function (response) {
            $scope.getBulkProductList = response.data;
        }
            ,
            function (error) {
                alert("failure in getdata");
            }

        )
    }
    //To get the color Filter results

    $scope.whiteColorFilter = function () {
        $http.post("/Product/GetWhiteColorFilter").then(function (response) {
            $scope.getBulkProductList = response.data;
        }
            ,
            function (error) {
                alert("failure in getdata");
            }

        )
    }
    $scope.registerHideFunction = function () {
        $scope.registerHide = true;
    }
  


    

});