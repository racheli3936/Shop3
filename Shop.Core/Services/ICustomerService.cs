using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomersSAsync(int password);
        Customer GetCustomerByIdS(string identity);
        void AddNewCustomerS(Customer customer,int employeeId);
        void UpdatePointsS(string custIdentity, double sumPay);
    }
}
