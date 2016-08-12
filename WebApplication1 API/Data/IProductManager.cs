using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagment;

namespace ProductDataManagment
{
    public interface IProductManager
    {
        
        List<Product> GetCatalogueProducts(int subCategoryId = -1);
      
        List<Product> GetProductDetails(int productId);

        List<ProductImages> GetProductImages(int productId);
    }
}
