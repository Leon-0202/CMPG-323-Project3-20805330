using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPower_Logistics.Data.Models;
using EcoPower_Logistics.Data.Data;

namespace EcoPower_Logistics.Data.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SuperStoreContext context) : base(context)
        {
        }

        public Customer GetCustomerById(int? id)
        {
            return GetAll().FirstOrDefault(x => x.CustomerId == id);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return GetAll().ToList();
        }

        public void AddCustomer(Customer entity)
        {
            Add(entity);
        }

        public void UpdateCustomer(Customer entity)
        {
            Update(entity);
        }

        public void RemoveCustomer(Customer entity)
        {
            Remove(entity);
        }
    }
}
