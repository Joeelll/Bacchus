using APIMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Bacchus.Controllers
{
    public class AuctionController : Controller
    {
        // GET: Auctions
        public ActionResult Index()
        {
            var auctions = GetAuctionsFromAPI();
            var categories = GetCategoriesFromList();

            return View(auctions);
        }

        private List<AuctionCategory> GetCategoriesFromList()
        {
            var resultList = new List<AuctionEntity>();
            var categoryList = new List<AuctionCategory>();

            foreach (var item in resultList)
            {
                categoryList.Add(new AuctionCategory() { productCategory = item.productCategory });
            }
            List<AuctionCategory> categories = categoryList.Distinct().ToList();

            return categories;
        }

        private List<AuctionEntity> GetAuctionsFromAPI()
        {
            try
            {
                var resultList = new List<AuctionEntity>();
                //
                var client = new HttpClient();
                var getDataTask = client.GetAsync("http://uptime-auction-api.azurewebsites.net/api/Auction")
                    .ContinueWith(response =>
                    {
                        var result = response.Result;
                        if (result.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            var readResult = result.Content.ReadAsAsync<List<AuctionEntity>>();
                            readResult.Wait();
                            resultList = readResult.Result;
                        }
                    });

                getDataTask.Wait();
                return resultList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}