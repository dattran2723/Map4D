using Map4D.Models;
using Map4D.Models.DataTableResponse;
using Map4D.Models.Repository;
using System.Linq;
using System.Web.Http;

namespace Map4D.API
{
    public class ContactsController : ApiController
    {
        private IContactRepository contactRepository;
        public ContactsController()
        {
            this.contactRepository = new ContactRepository(new ApplicationDbContext());
        }

        [HttpGet]
        [Route("api/contact")]
        public DataTableResponse GetContacts()
        {
            var contacts = contactRepository.GetContacts();
            return new DataTableResponse
            {
                recordsTotal = contacts.Count(),
                recordsFiltered = contacts.Count(),
                data = contacts.OrderByDescending(x => x.CreatedDate).ToArray()
            };
        }
    }
}
