using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FooterManagment;

namespace FooteDataManagment
{
    public interface IFooterManager
    {
        List<FooterTab> GetFooterTabs();
    }
}
