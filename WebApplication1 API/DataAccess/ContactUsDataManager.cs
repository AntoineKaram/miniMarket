using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContactUsManagment;
using DataAccess.Base;
using DataExtensions;

namespace ContactUsDataManagment
{
    public class ContactUsDataManager : DataManagerBase, IContactUsManager
    {
        public string OnSend(ContactUsModel contactUS)
        {
            if (contactUS != null)
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("@FirstName", (contactUS.FirstName != null) ? contactUS.FirstName : "");
                dict.Add("@LastName", (contactUS.LastName != null) ? contactUS.LastName : "");
                dict.Add("@Email", (contactUS.Email != null) ? contactUS.Email : "");
                dict.Add("@MessageType", (contactUS.MessageType != null) ? contactUS.MessageType : "");
                dict.Add("@MessageText", (contactUS.MessageText != null) ? contactUS.MessageText : "");

                if (ExecuteCommand("USP_ContactUS_Insert", dict))
                {
                    return ("Succeeded");
                }
                else
                {
                    return ("Failed");
                }

            }
            return ("Missing parameters");
        }
    }
}
