using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuDataManagment;


namespace MenuManagment
{
    public class MenuManager
    {
        private readonly IMenuManager _iMenuManager;
        public MenuManager() : this(new MenuDataManager())
        {

        }

        public MenuManager(IMenuManager iMenuManager)
        {
            _iMenuManager = iMenuManager;
        }

        public List<MenuTab> GetMenuTabs()
        {
            return _iMenuManager.GetMenuTabs();
        }
    }
}
