using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarouselManagment;
using DataExtensions;
using DataAccess.Base;

namespace CarouselDataManagment
{
   public class CarouselDataManager:DataManagerBase,ICarouselManager
    {

        public List<Carousel> GetCarousels()
        {
            List<Carousel> carousels = new List<Carousel>();
            carousels = ExecuteCollection<Carousel>("USP_CarouselImages_Get",
                 (reader) =>
                 {
                     Carousel tempCarousel = new Carousel()
                     {
                         ImageUrl = reader.GetValue<string>(0),
                         ImageCaption = reader.GetValue<string>(1),
                         ImgAlternative = reader.GetValue<string>(2),
                         ImageClass = reader.GetValue<string>(3)

                     };

                     return tempCarousel;
                 });
            return carousels;
        }
    }
}
