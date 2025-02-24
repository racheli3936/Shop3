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
        Task<List<Customer>> GetAllCustomersAsync(int password);
        Customer GetCustomerById(string identity);
        void AddNewCustomerAsync(Customer customer, int employeeId);
        void UpdatePointsAsync(string custIdentity, double sumPay);

    }
}
