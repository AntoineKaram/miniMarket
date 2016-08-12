using System;
using System.Collections.Generic;
using NewsManagment;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyApp.Controllers
{
    public class NewsController : ApiController
    {
        [HttpGet]
        public List<News> GetNews()
        {
            NewsManager newsManager = new NewsManager();
            return newsManager.GetNews();
        }
    }
}
