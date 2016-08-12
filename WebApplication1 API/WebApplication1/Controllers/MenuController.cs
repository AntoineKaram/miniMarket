using System;
using System.Collections.Generic;
using MenuManagment;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyApp.Controllers
{
    public class MenuController : ApiController
    {
        private MenuManager _menuManager;
        public MenuController()
        {
            _menuManager = new MenuManager();
        }
        
        [HttpGet]
        public List<MenuTab> GetMenu()
        {
            return _menuManager.GetMenuTabs();
        }
    }
}
