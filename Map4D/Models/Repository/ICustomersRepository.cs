using System.Linq;

namespace Map4D.Models.Repository
{
    public interface ICustomersRepository
    {
        IQueryable<Customer> GetCustomers();
    }

    public class CustomersRepository : ICustomersRepository
    {
        private ApplicationDbContext db;
        public CustomersRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Customer> GetCustomers()
        {
            return db.Customers;
        }
    }
}