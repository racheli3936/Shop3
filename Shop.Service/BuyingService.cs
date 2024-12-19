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
    public class BuyingService:IBuyingService
    {
        private readonly IBuyingRepository _buyingRepository;
        public BuyingService(IBuyingRepository buyingRepository)
        {
            _buyingRepository = buyingRepository;
        }
        public Order GetBuyingS(int orderId)
        {
          return  _buyingRepository.GetBuying(orderId);
        }
        public bool AddProductBuyS(Product product,int odretId)
        {
          return _buyingRepository.AddProductBuy(product,odretId);
        }
        public bool AddAmountBuyS(Product product, int orderId)
        {
           return _buyingRepository.AddAmountBuy(product, orderId);
        }
        public bool DeleteProductBuyS(Product product, int orderId)
        {
           return _buyingRepository.DeleteProductBuy(product, orderId);
        }
    }
}
