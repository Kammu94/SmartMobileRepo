using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileSiteBusinessEntities;


namespace MobileSiteDataLayer
{
    public class MobileSiteRepository
    {
        public bool Submit(Guid ProductId, string ProductName, Decimal SellingPrice, Decimal MarketPrice, int Stock, string Description, 
             int Rating, string OperatingSystem, string Color, bool IsAvailable, string FirstImage, string SecondImage, string ThirdImage,int FeatureType, int pageType)
        {
            using (var ConStr = ConnectionHandler.GetConString())
            {
                var repos = ConStr.ProcInsertProducts(ProductId, ProductName, SellingPrice, MarketPrice, Stock, Description,
                            Rating, OperatingSystem, Color, IsAvailable, FirstImage, SecondImage, ThirdImage,FeatureType, pageType);
            }
            return true;
        }

        public List<ProductDetailEntities> GetProducts()
        {
            using (var ConStr = ConnectionHandler.GetConString())
            {
                var repo = (from o in ConStr.ProcGetProductData()
                            select new ProductDetailEntities
                            {
                                ProductId = (Guid)o.ProductId,
                                ProductName = o.ProductName,
                                SellingPrice = o.SellingPrice.GetValueOrDefault(),
                                MarketPrice = o.MarketPrice.GetValueOrDefault(),
                                Stock = (int)o.Stock,
                                Description = o.Description,
                                DateOfInsert=o.DateOfInsert.GetValueOrDefault(),
                                Rating = (int)o.Rating,
                                OperatingSystem = o.OperatingSystem,
                                Color = o.Color,
                                IsAvailable = (bool)o.IsAvailable,      
                                FirstImage = o.FirstImage,
                                SecondImage = o.SecondImage,
                                ThirdImage = o.ThirdImage,
                                FeatureType=o.FeatureType.GetValueOrDefault(),
                                PageType=o.PAgeType.GetValueOrDefault()

                            }
                           ).ToList();
                return repo;
            }
        }

            public bool DeleteUser(Guid ProductId)
            {
                using (var ConStr = ConnectionHandler.GetConString())
                {
                    var repos = ConStr.ProcDeleteProduct(ProductId);
                }
                return true;
            }
        //EditProduct
        //public List<ProductDetailEntities> EditProduct(Guid ProductId)
        //{
        //    using (var ConStr = ConnectionHandler.GetConString())
        //    {
        //        var repo = (from o in ConStr.ProcEditProductTable(ProductId)
        //                    select new ProductDetailEntities
        //                    {
        //                        ProductId=o.ProductId,
        //                        ProductName = o.ProductName,
        //                        SellingPrice = (float)o.SellingPrice,
        //                        MarketPrice = (float)o.MarketPrice,
        //                        Stock = (int)o.Stock,
        //                        Description = o.Description,
        //                        DateOfInsert = o.DateOfInsert,
        //                        Rating = (int)o.Rating,
        //                        OperatingSystem = o.OperatingSystem,
        //                        Color = o.Color,
        //                        IsAvailable = (bool)o.IsAvailable,
        //                        FirstImage = o.FirstImage,
        //                        SecondImage = o.SecondImage,
        //                        ThirdImage = o.ThirdImage

        //                    }
        //                   ).ToList();
        //        return repo;
        //    }
        //}




    }
}
