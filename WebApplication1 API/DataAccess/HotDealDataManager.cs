using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotDealsManagment;
using DataAccess.Base;
using DataExtensions;

namespace HotDealsDataManagment
{
    public class HotDealDataManager : DataManagerBase, IHotDealManager
    {
        public List<HotDeal> GetHotDeals()
        {
            List<HotDeal> hotdeals = new List<HotDeal>();
            hotdeals = ExecuteCollection<HotDeal>("USP_HotDeal_Get",
                 (reader) =>
                 {
                     HotDeal tempDeal = new HotDeal()
                     {
                         Header = reader.GetValue<string>(0),
                         Text = reader.GetValue<string>(1),
                         ImageUrl = reader.GetValue<string>(2),
                         ImageAlternative = reader.GetValue<string>(3),
                         Link = reader.GetValue<string>(4),
                         ProductId=reader.GetValue<int>(5)
                     };
                     return tempDeal;
                 });

            return hotdeals;
        }
    }
}
