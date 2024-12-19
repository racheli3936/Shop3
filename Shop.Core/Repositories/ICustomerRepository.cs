using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers(int password);
        Customer GetCustomerById(string identity);
        void AddNewCustomer(Customer customer, int employeeId);
        void UpdatePoints(string custIdentity, double sumPay);

    }
}
