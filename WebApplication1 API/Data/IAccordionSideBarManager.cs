using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AccordionSideBarManagment;

namespace SideBarDataManagment
{
    public interface ISideBarManager
    {
       CategoryPayload GetCategories();
        List<SubCategory> GetSubCategories(int categoryId);
    }
}
