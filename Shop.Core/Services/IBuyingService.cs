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
        bool AddProductBuyS(Product product, int orderId);
        bool AddAmountBuyS(Product product, int orderId);
        bool DeleteProductBuyS(Product product, int orderId);
    }
}
