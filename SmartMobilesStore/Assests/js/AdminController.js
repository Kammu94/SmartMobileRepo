app.controller("AdminController", function ($scope, $http) {

  
    $scope.prod = {};
    $scope.getList = [];//TO STORE THE RESULT FROM DATABASE
    $scope.FirstImage = '';
    $scope.SecondImage = '';
    $scope.ThirdImage = '';
    $scope.EditedData = [];//to store the edited text in an obj


    $scope.sendDetails = function () {

        obj = {
            ProductId: $scope.prod.ProductId,
            ProductName: $scope.prod.ProductName,
            SellingPrice: $scope.prod.SellingPrice,
            MarketPrice: $scope.prod.MarketPrice,
            Stock: $scope.prod.Stock,
            Description: $scope.prod.Description,
            Rating: $scope.prod.Rating,
            OperatingSystem: $scope.prod.OperatingSystem,
            Color: $scope.prod.Color,
            IsAvailable: $scope.prod.IsAvailable,
            FirstImage: $scope.FirstImage,
            SecondImage: $scope.SecondImage,
            ThirdImage: $scope.ThirdImage,
            FeatureType: $scope.prod.featureType,
            PageType:$scope.prod.PageType


        };
        $http.post("/Admin/Submit",obj).then
            (function (success) {

                $scope.FirstImage = $scope.prod.FirstImage;
                $scope.SecondImage = $scope.prod.SecondImage;
                $scope.ThirdImage = $scope.prod.ThirdImage;
                $scope.getData();
                $scope.prod = {};

                form.$setPristine();
                form.$setUntouched();
                
                
            }, function (error) {
                alert("Failure");
            })
    }
    //to show the Product table on frontend
    $scope.getData = function () {
        $http.post("/Admin/GetProducts").then(function (response) {
            $scope.getList = response.data
        }
            ,
            function (error) {
                alert("failure in getdata")
            }

        )
    }
   
    $scope.uploadFile = function (file, id) {
        var fd = new FormData();
        fd.append("file", file[0]);
        var uploadUrl = "/Admin/ImageUploader/";
        $http.post(uploadUrl, fd, {
            withCredentials: true,
            headers: { 'Content-Type': undefined },
            transformRequest: angular.identity
        }).then(
            function (resp) {
                if (id == 1) {
                    $scope.FirstImage = resp.data;

                }
                if (id == 2) {
                    $scope.SecondImage = resp.data;
                }
                if (id == 3) {
                    $scope.ThirdImage = resp.data;
                }

            },
            function (error) {
                alert("error");
            }
            );
    };



    //function to delete data from product list
    $scope.deleteProduct = function (id) {

        $http.post("/Admin/DeleteUser", { ProductId: id }).then
            (function (response) {

                $scope.getData();

            }, function (error) {
                alert("Dont Get Data from Database")
            }
            )

    }
     //To edit the product details in admin controller
   
    $scope.editProduct = function (prod) {
   
        $scope.prod = prod;
        //$scope.prod.ProductName = $scope.EditedData[0].ProductName;
        //$scope.prod.SellingPrice = $scope.EditedData[0].SellingPrice;
        //$scope.prod.MarketPrice = $scope.EditedData[0].MarketPrice;
        //$scope.prod.Stock = $scope.EditedData[0].Stock;
        //$scope.prod.Description = $scope.EditedData[0].Description;
        //$scope.prod.DateOfInsert = $scope.EditedData[0].DateOfInsert;
        //$scope.prod.Rating = $scope.EditedData[0].Rating;
        //$scope.prod.OperatingSystem = $scope.EditedData[0].OperatingSystem;
        //$scope.prod.Color = $scope.EditedData[0].Color;
        //$scope.prod.IsAvailable = $scope.EditedData[0].IsAvailable;
        //$scope.prod.FirstImage = $scope.EditedData[0].FirstImage;
        //$scope.prod.SecondImage = $scope.EditedData[0].SecondImage;
        //$scope.prod.ThirdImage = $scope.EditedData[0].ThirdImage;
        //$http.post("/Admin/EditProduct", { ProductId: id }).then
        //    (function (response) {
               


        //    }

        //    )
    }
   
   

});