using EcoPower_Logistics.Data.Models;
using EcoPower_Logistics.Data.Repositories;

namespace EcoPower_Logistics.Service.Services
{
    /** 
     * This class is part of the service layer that is positioned between the repository layer,
     * and controller layer.
     * It provides flexibility to the controllers, making it easier for them to pull information
     * from multiple repositories.
     * It also further abstracts the controllers from the data access logic.
     * This service class is implemented specifically on Customer.
     */
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer GetCustomerById(int? id)
        {
            return _customerRepository.GetCustomerById(id);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }

        public void AddCustomer(Customer entity)
        {
            _customerRepository.AddCustomer(entity);
        }

        public void UpdateCustomer(Customer entity)
        {
            _customerRepository.UpdateCustomer(entity);
        }

        public void RemoveCustomer(Customer entity)
        {
            _customerRepository.RemoveCustomer(entity);
        }
    }
}
