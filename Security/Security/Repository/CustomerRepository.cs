using Security.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Security.Repository
{
    public interface ICustomerRepository
    {
        void Insert(Customer cu);
        void Update(Customer cu);
        void Delete(int id);
        List<Customer> GetAll();
        Customer GetById(int id);
    }
    public class CustomerRepository : ICustomerRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            return db.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return db.Customers.Find(id);
        }

        public void Insert(Customer cu)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer cu)
        {
            throw new NotImplementedException();
        }
    }
}