using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductDataManagment;

namespace ProductManagment
{
    public class ProductManager
    {
        private readonly IProductManager _iProductManager;
        public ProductManager() : this(new ProductDataManager())
        {

        }

        public ProductManager(IProductManager iProductManager)
        {
            _iProductManager = iProductManager;
        }


        public List<Product> GetCatalogueProducts(int subCategoryId = -1)
        {
            return _iProductManager.GetCatalogueProducts(subCategoryId);
        }
        public List<Product> GetProductDetails(int productId)
        {
            return _iProductManager.GetProductDetails(productId);
        }
        public List<ProductImages> GetProductImages(int productId)
        {
            return _iProductManager.GetProductImages(productId);
                }

    }
}
