using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileSiteBusinessLogic;
using MobileSiteDataLayer;
using MobileSiteBusinessEntities;


namespace SmartMobilesStore.Controllers
{
    public class ProductController : Controller
    {
        HomePageRepository product = new HomePageRepository();
        HomePageServices service = new HomePageServices();
        // GET: Product
  
        public JsonResult GetNewProductsList()
        {
            var ProductsList = service.GetNewProductsList();
            return Json(ProductsList);


        }
        //it will get the related Products list
        public JsonResult GetListOfProducts()
        {
            var ProductsListHome = service.GetListOfProducts();
            return Json(ProductsListHome);


        }
        //it will get the list of products on list page
        public JsonResult GetProductsList()
        {
            var data = service.GetProductsList();
            //var ProductModel = new ProductDetailModel
            //{
            //    ProductId = data.ProductId,
            //    ProductName = data.ProductName,
            //    SellingPrice = data.SellingPrice,
            //    MarketPrice = data.MarketPrice,
            //    Stock = data.Stock,
            //    Description = data.Description,
            //    DateOfInsert = data.DateOfInsert,
            //    Rating = data.Rating,
            //    OperatingSystem = data.OperatingSystem,
            //    Color = data.Color,
            //    IsAvailable = data.IsAvailable,
            //    FirstImage = data.FirstImage,
            //    SecondImage = data.SecondImage,
            //    ThirdImage = data.ThirdImage
            //};
            return Json(data);


        }
        //GetColorFilteredProductsList
        public JsonResult GetBlueColorFilter()
        {
            var data = service.GetBlueColorFilter();
           
            return Json(data);


        }
        //GetColorFilteredProductsList
        public JsonResult GetBlackColorFilter()
        {
            var data = service.GetBlackColorFilter();

            return Json(data);


        }
        //GetColorFilteredProductsList
        public JsonResult GetWhiteColorFilter()
        {
            var data = service.GetWhiteColorFilter();

            return Json(data);


        }
        //GetColorFilteredProductsList
        public JsonResult GetRedColorFilter()
        {
            var data = service.GetRedColorFilter();

            return Json(data);


        }



        public ActionResult DescriptionPage(Guid id)
        {
            var data = service.DescriptionPage(id);
            var productdetail = new ProductDetailModel
            {
                ProductId=data.ProductId,
                ProductName=data.ProductName,
                SellingPrice= data.SellingPrice,
                MarketPrice=data.MarketPrice,
                Stock=data.Stock,
                Description=data.Description,
                Rating=data.Rating,
                OperatingSystem=data.OperatingSystem,
                Color=data.Color,
                IsAvailable=data.IsAvailable,
                FirstImage=data.FirstImage,
                SecondImage=data.SecondImage,
                ThirdImage=data.ThirdImage
               
            };


          return  View(data);

        }
        public ActionResult ProductListPage()
        {
            return View();
        }

    }
}