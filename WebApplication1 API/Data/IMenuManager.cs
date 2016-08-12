using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuManagment;

namespace MenuDataManagment
{
   public interface IMenuManager
    {
        List<MenuTab> GetMenuTabs();
    }
}
