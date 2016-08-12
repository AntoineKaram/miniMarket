using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FooterManagment;
using DataAccess.Base;
using DataExtensions;

namespace FooteDataManagment
{
   public class FooterDataManager : DataManagerBase, IFooterManager
    {
        public List<FooterTab> GetFooterTabs()
        {
            List<FooterTab> footerTabs = new List<FooterTab>();
            footerTabs = ExecuteCollection<FooterTab>("USP_FooterTabs_Get",
                 (reader) =>
                 {
                     FooterTab tempTab = new FooterTab()
                     {
                         TabId = reader.GetValue<int>(0),
                         TabText = reader.GetValue<string>(1),
                         TabLink = reader.GetValue<string>(2),
                     };
                     return tempTab;
                 });

            return footerTabs;
        
    }
    }
}
