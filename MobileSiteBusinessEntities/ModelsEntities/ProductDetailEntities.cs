﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSiteBusinessEntities    
{
   public  class ProductDetailEntities
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal MarketPrice { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public DateTime DateOfInsert { get; set; }
        public int Rating { get; set; }
        public string OperatingSystem { get; set; }
        public string Color { get; set; }
        public bool IsAvailable { get; set; }
        public string FirstImage { get; set; }
        public string SecondImage { get; set; }
        public string ThirdImage { get; set; }
        public string Message { get; set; }
        public  int FeatureType { get; set; }
        public int PageType { get; set; }

    }
}
