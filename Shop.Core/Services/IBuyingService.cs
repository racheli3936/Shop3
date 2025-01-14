using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Services
{
    public interface IBuyingService
    {
        Order GetBuyingS(int orderId);
        bool AddProductBuyS(int productId, int orderId);
        bool AddAmountBuyS(int productId, int orderId);
        bool DeleteProductBuyS(int productId, int orderId);
    }
}
