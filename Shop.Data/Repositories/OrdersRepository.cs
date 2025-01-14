using Microsoft.EntityFrameworkCore;
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
            return _context.Orders.Include(order => order.Customer).Include(order => order.AllProducts).Include(order=>order.Customer.ClubCard).ToList();
        }
        public Order GetOrderById(int orderId)
        {
            return _context.Orders.Include(order=>order.AllProducts).Include(order=>order.Customer).Include(order=>order.Customer.ClubCard).FirstOrDefault(item => item.Id == orderId);
           
        }
        public int AddOrder(string Identity)
        {
            Customer customer = _context.Customers.First(cust=>cust.Identity==Identity);
            Order currentOrder = new Order() { Customer = customer,DateOrder=DateTime.Now,SumBuying=0 };
          
            _context.Orders.Add(currentOrder);
            _context.SaveChanges();
            return currentOrder.Id;

        }
    }
}
