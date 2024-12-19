using Shop.Core.Entities;
using Shop.Core.Repositories;
using Shop.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public class CustomerService : ICustomerService

    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public List<Customer> GetAllCustomersS(int password)
        {
            return _customerRepository.GetAllCustomers(password);
        }
   
        public Customer GetCustomerByIdS(string identity)
        {
            return _customerRepository.GetCustomerById(identity);
        }
        public void AddNewCustomerS(Customer customer, int employeeId)
        {
            _customerRepository.AddNewCustomer(customer,employeeId);
        }
        public void UpdatePointsS(string custIdentity, double sumPay)
        {
            _customerRepository.UpdatePoints(custIdentity , sumPay);
        }
      
    }
}
