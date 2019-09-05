using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIMessages
{
    public class AuctionEntity
    {
        public string productID { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public string productCategory { get; set; }
        public DateTime biddingEndDate { get; set; }
    }
    public class AuctionCategory
    {
        public string productCategory { get; set; }
    }
    public class AuctionBidding
    {
        public string productID { get; set; }
        public string bidderName { get; set; }
        public decimal biddingAmount { get; set; }
        public DateTime biddingDate { get; set; }
    }

//    @{List<string> list = new List<string>();
//        foreach (var item in Model)
//        {
//            list.Add(item.productCategory);
//        }
//List<string> categories = list.Distinct().ToList();
//    }
}