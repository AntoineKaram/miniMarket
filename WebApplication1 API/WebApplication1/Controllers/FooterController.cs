using System;
using System.Collections.Generic;
using FooterManagment;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyApp.Controllers
{
    public class FooterController : ApiController
    {
        private FooterManager _footerManager;
        public FooterController()
        {
            _footerManager = new FooterManager();
        }

        [HttpGet]
        public List<FooterTab> GetFooter()
        {
            return _footerManager.GetFooterTabs();
        }

    }
}
