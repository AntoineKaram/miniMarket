using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactUsManagment
{
    public class ContactUsModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MessageType { get; set; }
        public string MessageText { get; set; }
    }
}