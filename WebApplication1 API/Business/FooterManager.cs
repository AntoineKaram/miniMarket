using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FooteDataManagment;

namespace FooterManagment
{
    public class FooterManager
    {
        private readonly IFooterManager _iFooterManager;

        public FooterManager() : this(new FooterDataManager())
        {

        }

        public FooterManager(IFooterManager iFooterManager)
        {
            _iFooterManager = iFooterManager;
        }

        public List<FooterTab> GetFooterTabs()
        {
            return _iFooterManager.GetFooterTabs();
        }
    }
}
