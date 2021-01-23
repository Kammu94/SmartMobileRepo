using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileSiteDataLayer;
using MobileSiteBusinessEntities;


namespace MobileSiteBusinessLogic
{
    public class MobileSiteServices
    {
        MobileSiteRepository Add = new MobileSiteRepository();

        public bool Submit(Guid ProductId, string ProductName, Decimal SellingPrice, Decimal MarketPrice, int Stock,
           string Description, int Rating, string OperatingSystem, string Color, bool IsAvailable,
           string FirstImage, string SecondImage, string ThirdImage, int FeatureType, int PageType)
        {
            Add.Submit(ProductId, ProductName, SellingPrice, MarketPrice, Stock, Description, Rating,
                OperatingSystem, Color, IsAvailable, FirstImage, SecondImage, ThirdImage, FeatureType,PageType);

            return true;
        }
        public List<ProductDetailEntities> GetProducts()
        {
            return Add.GetProducts();
        }
        public bool DeleteUser(Guid ProductId)
        {
            Add.DeleteUser(ProductId);
            return true;


        }
        //EditProduct service method
        //public List<ProductDetailEntities> EditProduct(Guid ProductId)
        //{
        //   return Add.EditProduct(ProductId);
            

        //}

    }
}
