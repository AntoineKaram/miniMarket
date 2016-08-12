using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsManagment;
using DataAccess.Base;
using DataExtensions;

namespace NewsDataManagment
{
    public class NewsDataManager : DataManagerBase, INewsManager
    {   
        public List<News> GetNews()
        {
            List<News> news = new List<News>();
            news = ExecuteCollection<News>("USP_News_Get",
                 (reader) =>
                 {
                     News tempNews = new News()
                     {
                         Text = reader.GetValue<string>(0),
                         Link = reader.GetValue<string>(1)
                     };
                     return tempNews;
                 });

            return news;
        }
    }
}
