using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotDealsManagment
{
    public class HotDeal
    {
        
        public string Header { get; set; }
        public string Text { get; set; }
        public string ImageUrl { get; set; }
        public string ImageAlternative { get; set; }
        public string Link { get; set; }
        public int ProductId { get; set; }
    }
}