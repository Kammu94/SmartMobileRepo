using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileSiteDataLayer;
using MobileSiteBusinessEntities;

namespace MobileSiteBusinessLogic
{
    public  class HomePageServices
    {
        HomePageRepository Add = new HomePageRepository();

        public List<ProductDetailEntities> GetNewProductsList()
        {
            return Add.GetNewProductsList();
        }
        public List<ProductDetailEntities> GetListOfProducts()
        {
            return Add.GetListOfProducts();
        }
        public  ProductDetailEntities DescriptionPage(Guid ProductId)
        {
            return Add.DescriptionPage(ProductId);
        }
        //It will get the list of products on products page
        public List<ProductDetailEntities> GetProductsList()
        {
            return Add.GetProductsList();

        }
        //GetColorFilteredProductsList
        public List<ProductDetailEntities> GetBlueColorFilter()
        {
            return Add.GetBlueColorFilter();

        }
        //GetColorFilteredProductsList
        public List<ProductDetailEntities> GetRedColorFilter()
        {
            return Add.GetRedColorFilter();

        }
        //GetColorFilteredProductsList
        public List<ProductDetailEntities> GetWhiteColorFilter()
        {
            return Add.GetWhiteColorFilter();

        }
        //GetColorFilteredProductsList
        public List<ProductDetailEntities> GetBlackColorFilter()
        {
            return Add.GetBlackColorFilter();

        }





    }
}
