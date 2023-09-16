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
            return _customerRepository.GetAll().FirstOrDefault(x => x.CustomerId == id);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAll().ToList();
        }

        public void AddCustomer(Customer entity)
        {
            _customerRepository.Add(entity);
        }

        public void UpdateCustomer(Customer entity)
        {
            _customerRepository.Update(entity);
        }

        public void RemoveCustomer(Customer entity)
        {
            _customerRepository.Remove(entity);
        }
    }
}
