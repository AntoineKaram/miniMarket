using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsDataManagment;

namespace NewsManagment
{
    public class NewsManager
    {

        private readonly INewsManager _iNewsManager;
        public NewsManager() : this(new NewsDataManager())
        {
        }

        public NewsManager(INewsManager newsManager)
        {
            _iNewsManager = newsManager;

        }

        public List<News> GetNews()
        {
            return _iNewsManager.GetNews();
        }
    }
}
