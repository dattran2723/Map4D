using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Map4D.Models.Repository
{
    public interface IContactRepository
    {
        IQueryable<Contact> GetContacts();
    }
    public class ContactRepository : IContactRepository
    {
        private ApplicationDbContext db;
        public ContactRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Contact> GetContacts()
        {
            return db.Contacts;
        }


    }
}