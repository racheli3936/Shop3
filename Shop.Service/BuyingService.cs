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
        public bool AddAmountBuyS(int productId, int orderId)
        {
          return _buyingRepository.AddAmountBuy(productId,orderId);
        }
        public bool AddProductBuyS(int productId, int orderId)
        {
           return _buyingRepository.AddProductBuy(productId, orderId);
        }
        public bool DeleteProductBuyS(int productId, int orderId)
        {
           return _buyingRepository.DeleteProductBuy(productId, orderId);
        }

    }
}
