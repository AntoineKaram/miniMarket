using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotDealsDataManagment;

namespace HotDealsManagment
{
   public class HotDealManager
    {
        private readonly IHotDealManager _iHotDealManager;
        public HotDealManager() :this(new HotDealDataManager())
        {

        }
        public HotDealManager(IHotDealManager iHotDealManager)
        {
            _iHotDealManager = iHotDealManager;
        }

        public List<HotDeal> GetHotDeals()
        {
            return _iHotDealManager.GetHotDeals();
        }

    }
}
