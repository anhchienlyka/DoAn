﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HousewareShop.Web.Models
{

    public class ProductViewModel
    {

        public int ID { set; get; }

        public string Name { set; get; }

        public string Alias { set; get; }

        public int CategoryID { set; get; }

        public string Image { set; get; }

        public string MoreImages { set; get; }

        public decimal Price { set; get; }

        public decimal? PromotionPrice { set; get; }


        public int? Warranty { set; get; }
        public int Quantity { set; get; }
        public string Description { set; get; }

        public string Content { set; get; }

        public bool? HomeFlag { set; get; }

        public bool? HotFlag { set; get; }

        public int? ViewCount { set; get; }

        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        public string UpdatedBy { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public bool Status { set; get; }

        public string Tags { set; get; }
      
        public decimal OriginalPrice { set ; get; }
        //private decimal prices;
        //public decimal? Prices {
        //    set { if(PromotionPrice !=0)
        //        {
        //            Prices = PromotionPrice;
        //        }
        //    else
        //        {
        //            Prices = Price;
        //        }
        //         }
        //    get { return prices; }
        //}
        public virtual ProductCategoryViewModel ProductCategory { set; get; }

        
    }
}