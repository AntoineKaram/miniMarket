using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactUsDataManagment;

namespace ContactUsManagment
{
    public class ContactUsManager
    {
        private readonly IContactUsManager _iContactUsManager;
        public ContactUsManager():this(new ContactUsDataManager())
        {

        }

        public ContactUsManager(IContactUsManager iContactUsManager)
        {
            _iContactUsManager = iContactUsManager;
        }

        public string OnSend(ContactUsModel contactUS)
        {
            return _iContactUsManager.OnSend(contactUS);
        }
    }
}
