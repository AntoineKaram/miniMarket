using System;
using System.Collections.Generic;
using HotDealsManagment;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Controllers
{
    public class HotDealsController : ApiController
    {
        private HotDealManager _hotDealManager;

        public HotDealsController()
        {
           _hotDealManager = new HotDealManager();
        }

        [HttpGet]
        public List<HotDeal> GetHotDeals()
        {
            return _hotDealManager.GetHotDeals();
        }
    }
}
