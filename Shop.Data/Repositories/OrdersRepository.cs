using Shop.Core.Entities;
using Shop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly DataContext _context;
        public OrdersRepository(DataContext context) 
        {
            _context = context;
        }
        public List<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }
        public Order GetOrderById(int orderId)
        {
            return _context.Orders.FirstOrDefault(item => item.Id == orderId);
           
        }
        public int AddOrder(int custId)
        {
            Order currentOrder = new Order() { CustId=custId};
            _context.Orders.Add(currentOrder);
            _context.SaveChanges();
            return currentOrder.Id;

        }
    }
}
