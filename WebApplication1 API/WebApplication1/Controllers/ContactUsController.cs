using System.Web.Http;
using ContactUsManagment;


namespace MyApp.Controllers
{
    public class ContactUsController : ApiController
    {
        private ContactUsManager _contactUsManager;
        public ContactUsController()
        {
            _contactUsManager = new ContactUsManager();
        }

        [HttpPost]
        public string OnSend(ContactUsModel contactUS)
        {
            return _contactUsManager.OnSend(contactUS);
        }

        
    }
}
