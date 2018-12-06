using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Map4D.Models.Repository;
using Map4D.Models;
using Map4D.Models.DataTableResponse;

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
                recordsFiltered = 10,
                data = customers.Take(10).ToArray()
            };
        }
    }
}
