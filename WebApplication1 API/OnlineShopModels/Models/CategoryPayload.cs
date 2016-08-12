using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace AccordionSideBarManagment
{
    public class CategoryPayload
    {
        public List<Category> Categories{ get; set; }
        public Dictionary<int,List<SubCategory>> Subcategories { get; set; }
    }
}