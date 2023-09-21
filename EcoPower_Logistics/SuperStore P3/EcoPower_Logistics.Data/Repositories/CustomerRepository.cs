using EcoPower_Logistics.Data.Models;
using EcoPower_Logistics.Data.Data;

namespace EcoPower_Logistics.Data.Repositories
{
    /**
     * This repository class inherits from the generic repository class,
     * and indirectly accesses the DbContext through it.
     * This repository class is of model type Customer.
     * It makes us of the CRUD operations of the Generic repository class,
     * and provides implementation for returning either a specific or all Customer variables.
     */
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
