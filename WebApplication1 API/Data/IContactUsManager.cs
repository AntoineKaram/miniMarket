using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactUsManagment;

namespace ContactUsDataManagment
{
    public interface IContactUsManager
    {
        string OnSend(ContactUsModel contactUS);
    }
}
