using System;
using System.Collections.Generic;
using CarouselManagment;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyApp.Controllers
{
    public class CarouselController : ApiController
    {
        private CarouselManager _carouselManager;
        public CarouselController()
        {
           _carouselManager = new CarouselManager();
        }

        [HttpGet]
        public List<Carousel> GetCarousels()
        {
            return _carouselManager.GetCarousels();
        }

    }
}
