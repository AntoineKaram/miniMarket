using ProductManagment;
using System.Web.Http;
using System.Collections.Generic;

namespace MyApp.Controllers
{
    public class ProductController : ApiController
    {
        private ProductManager _productManager;
        public ProductController()
        {
           _productManager = new ProductManager();
        }

        [HttpGet]
        public List<Product> GetCatalogueProducts(int subCategoryId = -1)
        {
            return _productManager.GetCatalogueProducts(subCategoryId);
        }

        [HttpGet]
        public List<Product> GetProductDetails(int productId)
        {
            return _productManager.GetProductDetails(productId);
        }

    }
}
