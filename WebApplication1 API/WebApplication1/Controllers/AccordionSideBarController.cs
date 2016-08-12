using System;
using System.Collections.Generic;
using AccordionSideBarManagment;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyApp.Controllers
{
    public class AccordionSideBarController : ApiController
    {
        SideBarManager accordionManager = new SideBarManager(); //in product mgr
        [HttpGet]
        public CategoryPayload GetCategories() 
        {
            return accordionManager.GetCategories();
        }
    }
}
