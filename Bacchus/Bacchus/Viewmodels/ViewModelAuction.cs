using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bacchus.Viewmodels
{
    public class ViewModelAuction
    {
        public List<APIMessages.AuctionEntity> auctionEntities { get; set; }
        public List<APIMessages.AuctionCategory> auctionCategories { get; set; }
        public List<APIMessages.AuctionBidding> auctionBiddings { get; set; }
    }
}