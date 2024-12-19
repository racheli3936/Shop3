using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Repositories
{
    public interface IOrdersRepository
    {
        List<Order> GetOrders();
        Order GetOrderById(int orderId);
        int AddOrder (int custId);

    }
}
