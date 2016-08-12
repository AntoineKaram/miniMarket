using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarouselDataManagment;
namespace CarouselManagment
{
   public class CarouselManager
    {
        private readonly ICarouselManager _iCarouselManager;
        public CarouselManager() : this(new CarouselDataManager())
        {
        }

        public CarouselManager(ICarouselManager carouselManager)
        {
            _iCarouselManager = carouselManager;
        }
        public List<Carousel> GetCarousels()
        {
            return _iCarouselManager.GetCarousels();
        }
    }
}