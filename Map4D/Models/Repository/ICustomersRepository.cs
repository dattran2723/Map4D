using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Map4D.Models.Repository
{
    public interface ICustomersRepository
    {
        IQueryable<Customers> GetCustomers();
    }
    public class CustomersRepository : ICustomersRepository
    {
        private ApplicationDbContext db;
        public CustomersRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IQueryable<Customers> GetCustomers()
        {
            return db.Customers;
        }
    }
}