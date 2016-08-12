using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotDealsManagment;

namespace HotDealsDataManagment
{
    public interface IHotDealManager
    {
        List<HotDeal> GetHotDeals();
    }
}
