using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Repositories
{
    public interface IDataContext
    {
         List<ClubCard> ClubCards { get; set; }
         List<Product> Products { get; set; }
         List<Order> Orders { get; set; }
         List<Employee> Employees { get; set; }
         List<Customer> Customers { get; set; }
         int managerPassward { get; set; }
    }
}
