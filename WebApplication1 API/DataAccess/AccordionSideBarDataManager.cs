using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccordionSideBarManagment;
using DataAccess.Base;
using DataExtensions;

namespace SideBarDataManagment
{
    public class AccordionSideBarDataManager : DataManagerBase,ISideBarManager
    {
        public AccordionSideBarDataManager():base()
        {

        }
        public CategoryPayload GetCategories()
        {
            CategoryPayload result = new CategoryPayload();
            List<Category> categoriesList = ExecuteCollection("USP_Category_Get",
                (reader) =>
                {
                    Category tempCategory = new Category()
                    {
                        CategoryId = reader.GetValue<int>(0),
                        CategoryName = reader.GetValue<string>(1)
                    };

                    return tempCategory;
                });
            result.Categories = categoriesList;
            Dictionary<int, List<SubCategory>> SubCategories = new Dictionary<int, List<SubCategory>>();
            foreach (Category category in categoriesList)
            {
                SubCategories[category.CategoryId] = GetSubCategories(category.CategoryId);

            }
            result.Subcategories = SubCategories;
            return result;
        }

        public List<SubCategory> GetSubCategories(int categoryId)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("categoryId", categoryId.ToString());
            return ExecuteCollection("USP_SubCategory_Get",
                (reader) =>
                {
                    SubCategory tempSubCategory = new SubCategory()
                    {
                        SubCategoryId = reader.GetValue<int>(0),
                        SubCategoryName = reader.GetValue<string>(1),
                        CategoryId = reader.GetValue<int>(2)
                    };
                    return tempSubCategory;
                },
                param
                );
        }
    }
}
