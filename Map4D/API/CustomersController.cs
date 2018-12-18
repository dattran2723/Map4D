using Map4D.Models;
using Map4D.Models.DataTableResponse;
using Map4D.Models.Repository;
using System.Linq;
using System.Web.Http;

namespace Map4D.API
{
    public class CustomersController : ApiController
    {
        private ICustomersRepository customersRepository;
        public CustomersController()
        {
            this.customersRepository = new CustomersRepository(new ApplicationDbContext());
        }
        [HttpGet]
        [Route("api/customers")]
        public DataTableResponse GetCustomers()
        {
            var customers = customersRepository.GetCustomers();
            return new DataTableResponse
            {
                recordsTotal = customers.Count(),
                recordsFiltered = customers.Count(),
                data = customers.OrderByDescending(x => x.RegisterDate).ToArray(),
            };
        }
    }
}
