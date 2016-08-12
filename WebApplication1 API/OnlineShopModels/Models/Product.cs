using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManagment
{
    public class Product
    {
        public int Id { get; set; }
        public string DescriptionTitle { get; set; }
        public string DescriptionText { get; set; }
        public string DetailTitle { get; set; }
        
        public string DetailText { get; set; }
        public decimal Price { get; set; }
        public List<ProductImages> Images { get; set; }
    }
}