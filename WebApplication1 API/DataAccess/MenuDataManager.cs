using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Base;
using DataExtensions;
using MenuManagment;

namespace MenuDataManagment
{
    public class MenuDataManager : DataManagerBase, IMenuManager
    {
        public List<MenuTab> GetMenuTabs()
        {
            List<MenuTab> menuTabs = new List<MenuTab>();
            menuTabs = ExecuteCollection<MenuTab>("USP_MenuTabs_Get",
                 (reader) =>
                 {
                     MenuTab tempTab = new MenuTab()
                     {
                         TabId = reader.GetValue<int>(0),
                         TabText = reader.GetValue<string>(1),
                         TabLink = reader.GetValue<string>(2),
                     };
                     return tempTab;
                 });

            return menuTabs;
        }
    }
}
