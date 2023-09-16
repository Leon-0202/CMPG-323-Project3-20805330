using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPower_Logistics.Data.Models;
using EcoPower_Logistics.Data.Repositories;

namespace EcoPower_Logistics.Service.Services
{
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
