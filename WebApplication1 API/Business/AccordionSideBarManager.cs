using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

using SideBarDataManagment;

namespace AccordionSideBarManagment
{
    public class SideBarManager
    {
        private readonly ISideBarManager _iSideBarManager;
        public SideBarManager() : this(new AccordionSideBarDataManager())
        {
        }

        public SideBarManager(ISideBarManager SideBarManager)
        {
            _iSideBarManager = SideBarManager;

        }

        public CategoryPayload GetCategories()
        {
            return _iSideBarManager.GetCategories();
        }
    }
}
