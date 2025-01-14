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
    public class OrdersService:IOrdersService
    {
        private readonly IOrdersRepository _ordersRepository;
        public OrdersService(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public List<Order> GetOrdersS()
        {
           return _ordersRepository.GetOrders();
        }
        public Order GetOrderByIdS(int orderId)
        {
           return _ordersRepository.GetOrderById(orderId);
        }
        public int AddOrderS(string Identity)
        {
           return _ordersRepository.AddOrder(Identity);
        }
    }
}
