using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsManagment;

namespace  NewsDataManagment
{
    public interface INewsManager
    {
         List<News> GetNews();
    }
}
