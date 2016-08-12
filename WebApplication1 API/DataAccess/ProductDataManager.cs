using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductManagment;
using DataAccess.Base;
using DataExtensions;

namespace ProductDataManagment
{
    public class ProductDataManager : DataManagerBase, IProductManager
    {
        public List<Product> GetCatalogueProducts(int subCategoryId = -1)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("subCategoryId", subCategoryId.ToString());
            List<Product> productList = ExecuteCollection("USP_CatalogueProduct_Get",
                (reader) =>
                {
                    Product product = new Product()
                    {
                        Id = reader.GetValue<int>(0),
                        DescriptionTitle = reader.GetValue<string>(1),
                        Price = reader.GetValue<decimal>(2)
                    };

                    return product;
                }, param);
            foreach (Product product in productList)
            {
                product.Images = GetProductImages(product.Id);
            }
            return productList; ;
        }

        public List<Product> GetProductDetails(int productId)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("productId", productId.ToString());
            List<Product> productList = ExecuteCollection("USP_ProductDetails_Get",
                (reader) =>
                {
                    Product product = new Product()
                    {
                        Id = reader.GetValue<int>(0),
                        DescriptionTitle = reader.GetValue<string>(1),
                        DescriptionText = reader.GetValue<string>(2),
                        DetailTitle = reader.GetValue<string>(3),
                        DetailText = reader.GetValue<string>(4),
                        Price = reader.GetValue<decimal>(5)
                    };

                    return product;
                }, param);
            foreach (Product product in productList)
            {
                product.Images = GetProductImages(product.Id);
            }
            return productList;
        }

        public List<ProductImages> GetProductImages(int productId)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("productId", productId.ToString());
            List<ProductImages> productList = ExecuteCollection("USP_ProductImages_Get",
                (reader) =>
                {
                    ProductImages imagesUrl = new ProductImages
                    {
                        //ImagesUrl = new List<string> { reader.GetValue<string>(0) }
                        ImagesUrl = reader.GetValue<string>(0)
                    };

                    return imagesUrl;
                }, param);
            return productList;
        }
    }
}
